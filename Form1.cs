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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDispositivos();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbDispositivos.SelectedIndex < 0 || dispositivos == null)
                return;

            var device = dispositivos[cmbDispositivos.SelectedIndex];

            capture = new WasapiLoopbackCapture(device);

            mp3Writer = new LameMP3FileWriter(
                "gravacao_saida.mp3",
                capture.WaveFormat,
                192
            );

            capture.DataAvailable += (s, a) =>
            {
                mp3Writer.Write(a.Buffer, 0, a.BytesRecorded);
                AtualizarVuMeter(a.Buffer, a.BytesRecorded);
            };

            capture.StartRecording();

            lblStatus.Text = "Gravando (MP3)...";
            btnIniciar.Enabled = false;
            btnParar.Enabled = true;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            capture?.StopRecording();
            capture?.Dispose();
            mp3Writer?.Dispose();

            prgVolume.Value = 0;

            lblStatus.Text = "Gravação finalizada";
            btnIniciar.Enabled = true;
            btnParar.Enabled = false;
        }

        private void AtualizarVuMeter(byte[] buffer, int bytes)
        {
            float max = 0;

            for (int i = 0; i < bytes; i += 4)
            {
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
