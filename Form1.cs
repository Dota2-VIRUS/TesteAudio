using System;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Lame;

namespace GravadorAudioSaidaWin
{
    public partial class Form1 : Form
    {
        private WasapiLoopbackCapture? capture;
        private LameMP3FileWriter? mp3Writer;
        private MMDeviceCollection? dispositivos;

        public Form1()
        {
            InitializeComponent();
            CarregarDispositivos();
        }

        // Carrega dispositivos de saída ativos
        private void CarregarDispositivos()
        {
            var enumerator = new MMDeviceEnumerator();
            dispositivos = enumerator.EnumerateAudioEndPoints(
                DataFlow.Render,
                DeviceState.Active
            );

            cmbDispositivos.Items.Clear();

            foreach (var device in dispositivos)
                cmbDispositivos.Items.Add(device.FriendlyName);

            if (cmbDispositivos.Items.Count > 0)
                cmbDispositivos.SelectedIndex = 0;
        }

        // Botão atualizar lista
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDispositivos();
        }

        // Botão iniciar gravação do dispositivo selecionado
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbDispositivos.SelectedIndex < 0 || dispositivos == null)
                return;

            var device = dispositivos[cmbDispositivos.SelectedIndex];
            IniciarGravacao(device, "gravacao_saida.mp3");
            lblStatus.Text = "Gravando (MP3)...";
        }

        // Botão parar gravação
        private void btnParar_Click(object sender, EventArgs e)
        {
            PararGravacao();
        }

        // Botão testar áudio padrão
        private void btnTeste_Click(object sender, EventArgs e)
        {
            var enumerator = new MMDeviceEnumerator();
            var defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            IniciarGravacao(defaultDevice, "teste_audio_padrao.mp3");
            lblStatus.Text = "Gravando áudio padrão (teste)...";
        }

        // Método que inicia gravação
        private void IniciarGravacao(MMDevice device, string arquivo)
        {
            PararGravacao();

            capture = new WasapiLoopbackCapture(device);
            mp3Writer = new LameMP3FileWriter(arquivo, capture.WaveFormat, 192);

            capture.DataAvailable += (s, a) =>
            {
                mp3Writer.Write(a.Buffer, 0, a.BytesRecorded);
                AtualizarVuMeter(a.Buffer, a.BytesRecorded);
            };

            capture.RecordingStopped += (s, a) =>
            {
                mp3Writer?.Dispose();
                capture?.Dispose();
                BeginInvoke(new Action(() =>
                {
                    lblStatus.Text = "Gravação finalizada";
                    btnIniciar.Enabled = true;
                    btnParar.Enabled = false;
                }));
            };

            capture.StartRecording();
            btnIniciar.Enabled = false;
            btnParar.Enabled = true;
        }

        // Para a gravação
        private void PararGravacao()
        {
            if (capture != null)
            {
                capture.StopRecording();
                capture.Dispose();
                capture = null;
            }

            if (mp3Writer != null)
            {
                mp3Writer.Dispose();
                mp3Writer = null;
            }

            prgVolume.Value = 0;
            btnIniciar.Enabled = true;
            btnParar.Enabled = false;
        }

        // Atualiza o VU Meter
        private void AtualizarVuMeter(byte[] buffer, int bytes)
        {
            float max = 0;

            for (int i = 0; i < bytes; i += 4)
            {
                if (i + 3 >= buffer.Length) break;
                float sample = BitConverter.ToSingle(buffer, i);
                max = Math.Max(max, Math.Abs(sample));
            }

            int volume = (int)(max * 100);
            volume = Math.Min(100, volume);

            BeginInvoke(new Action(() =>
            {
                prgVolume.Value = volume;
            }));
        }
    }
}