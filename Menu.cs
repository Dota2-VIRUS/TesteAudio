using System.Diagnostics;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Lame;


namespace GravadorAudioSaidaWin
{
    public partial class Menu : Form
    {
        private WasapiLoopbackCapture? capture;
        private LameMP3FileWriter? mp3Writer;
        private MMDeviceCollection? dispositivos;
        private string exeSelecionado = "";

        private Keys hotkeyIniciar = Keys.S;
        private Keys hotkeyParar = Keys.P;
        private uint modifierIniciar = 0;
        private uint modifierParar = 0;

        private const int HOTKEY_ID_START = 1;
        private const int HOTKEY_ID_STOP = 2;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public Menu()
        {
            InitializeComponent();
            CarregarDispositivos();
            ReRegistrarHotkeys();
            CarregarHotkeysDoIni();

        }

        private void CarregarHotkeysDoIni()
        {
            string iniciar = IniHelper.Ler("HotkeyIniciar", "S");
            string parar = IniHelper.Ler("HotkeyParar", "P");

            txtHotkeyIniciar.Text = iniciar;
            txtHotkeyParar.Text = parar;

            // Parse para hotkeyIniciar + modifierIniciar
            ParseHotkeyString(iniciar, out hotkeyIniciar, out modifierIniciar);
            ParseHotkeyString(parar, out hotkeyParar, out modifierParar);

            ReRegistrarHotkeys();
        }

        private string GerarNomeArquivo(string prefixo)
        {
            string dataHora = DateTime.Now.ToString("ddMMyyyyHHmmss");
            return $"{prefixo}_{dataHora}.mp3";

        }

        private void ParseHotkeyString(string s, out Keys key, out uint modifier)
        {
            key = Keys.None;
            modifier = 0;

            if (string.IsNullOrEmpty(s)) return;

            string[] parts = s.Split('+');
            foreach (var p in parts)
            {
                if (p.Equals("Ctrl", StringComparison.OrdinalIgnoreCase)) modifier |= 0x0002;
                else if (p.Equals("Shift", StringComparison.OrdinalIgnoreCase)) modifier |= 0x0004;
                else if (p.Equals("Alt", StringComparison.OrdinalIgnoreCase)) modifier |= 0x0001;
                else
                {
                    try { key = (Keys)Enum.Parse(typeof(Keys), p); } catch { }
                }
            }
        }


        private void CarregarDispositivos()
        {
            var enumerator = new MMDeviceEnumerator();
            dispositivos = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);

            cmbDispositivos.Items.Clear();
            foreach (var device in dispositivos)
                cmbDispositivos.Items.Add(device.FriendlyName);

            if (cmbDispositivos.Items.Count > 0)
                cmbDispositivos.SelectedIndex = 0;
        }

        private void btnAtualizar_Click(object sender, EventArgs e) => CarregarDispositivos();

        private void btnTeste_Click(object sender, EventArgs e)
        {
            var enumerator = new MMDeviceEnumerator();
            var defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            string arquivo = GerarNomeArquivo("Dota 2 VIRUS teste");
            IniciarGravacao(defaultDevice, arquivo);
            lblStatus.Text = $"Gravando (teste): {arquivo}";
            
        }

       

        private void btnSelecionarExe_Click(object sender, EventArgs e)
        {
            Process[] processos = Process.GetProcesses();
            List<string> nomesApps = new List<string>();

            foreach (var processo in processos)
            {
                try
                {
                    string nomeApp = processo.ProcessName;
                    string caminhoExe = "";

                    try
                    {
                        caminhoExe = processo.MainModule?.FileName ?? "";
                    }
                    catch { }

                    if (!string.IsNullOrWhiteSpace(nomeApp) &&
                        !nomesApps.Contains(nomeApp) &&
                        !string.IsNullOrWhiteSpace(caminhoExe) &&
                        !caminhoExe.StartsWith(
                            Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                            StringComparison.OrdinalIgnoreCase) &&
                        !caminhoExe.Contains("WindowsApps"))
                    {
                        nomesApps.Add(nomeApp);
                    }
                }
                catch { }
            }

            nomesApps.Sort();

            // ===== FORM ESTILIZADO =====
            using (Form selecionarForm = new Form())
            {
                selecionarForm.Text = "Selecionar Aplicativo";
                selecionarForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                selecionarForm.StartPosition = FormStartPosition.CenterParent;
                selecionarForm.ClientSize = new Size(360, 450);
                selecionarForm.MaximizeBox = false;
                selecionarForm.BackColor = Color.FromArgb(240, 240, 240);
                selecionarForm.Font = new Font("Segoe UI", 9F);

                // Header
                Panel header = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 55,
                    BackColor = Color.FromArgb(0, 120, 215)
                };

                Label lblTitulo = new Label
                {
                    Text = "📁 Aplicativos em execução",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(15, 15)
                };

                header.Controls.Add(lblTitulo);

                // Lista
                ListBox lst = new ListBox
                {
                    DataSource = nomesApps,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 9.5F),
                    BorderStyle = BorderStyle.None
                };

                Panel panelLista = new Panel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(10),
                    BackColor = Color.White
                };

                panelLista.Controls.Add(lst);

                // Botão OK
                Button btnOk = new Button
                {
                    Text = "Selecionar",
                    Dock = DockStyle.Bottom,
                    Height = 45,
                    BackColor = Color.FromArgb(0, 120, 215),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnOk.FlatAppearance.BorderSize = 0;

                btnOk.Click += (s, e2) =>
                {
                    if (lst.SelectedItem == null) return;

                    selecionarForm.DialogResult = DialogResult.OK;
                    selecionarForm.Close();
                };

                // Duplo clique seleciona
                lst.DoubleClick += (s, e2) => btnOk.PerformClick();

                selecionarForm.Controls.Add(panelLista);
                selecionarForm.Controls.Add(btnOk);
                selecionarForm.Controls.Add(header);

                if (selecionarForm.ShowDialog() == DialogResult.OK)
                {
                    exeSelecionado = lst.SelectedItem!.ToString();
                    txtExecutavel.Text = exeSelecionado;
                }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(exeSelecionado))
            {
                var processos = Process.GetProcessesByName(exeSelecionado);
                if (processos.Length == 0)
                {
                    MessageBox.Show($"O aplicativo {exeSelecionado} não está em execução!");
                    return;
                }
            }

            if (cmbDispositivos.SelectedIndex < 0 || dispositivos == null) return;
            var device = dispositivos[cmbDispositivos.SelectedIndex];
            string arquivo = GerarNomeArquivo("dota2virus");
            IniciarGravacao(device, arquivo);
            lblStatus.Text = $"Gravando: {arquivo}";

        }

        private void btnParar_Click(object sender, EventArgs e) => PararGravacao();

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
                }));
            };

            capture.StartRecording();
            btnIniciar.Enabled = false;
            btnParar.Enabled = true;
            btnTeste.Enabled = false;
        }

        private void PararGravacao()
        {
            if (capture != null) { capture.StopRecording(); capture.Dispose(); capture = null; }
            if (mp3Writer != null) { mp3Writer.Dispose(); mp3Writer = null; }
            prgVolume.Value = 0;
            btnIniciar.Enabled = true;
            btnParar.Enabled = false;
            btnTeste.Enabled = true;
        }

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

        private void btnDefinirHotkeyIniciar_Click(object sender, EventArgs e)
        {
            using (HotkeyForm hk = new HotkeyForm())
            {
                if (hk.ShowDialog() == DialogResult.OK)
                {
                    txtHotkeyIniciar.Text = (hk.Ctrl ? "Ctrl+" : "") + (hk.Shift ? "Shift+" : "") + (hk.Alt ? "Alt+" : "") + hk.TeclaSelecionada.ToString();
                    
                    // Atualiza as variáveis usadas pelo RegisterHotKey
                    hotkeyIniciar = hk.TeclaSelecionada;
                    modifierIniciar = 0;
                    if (hk.Ctrl) modifierIniciar |= 0x0002;  // MOD_CONTROL
                    if (hk.Shift) modifierIniciar |= 0x0004; // MOD_SHIFT
                    if (hk.Alt) modifierIniciar |= 0x0001;   // MOD_ALT

                    ReRegistrarHotkeys(); // Re-registrar a hotkey global

                    // Salva no ini
                    IniHelper.Salvar("HotkeyIniciar", txtHotkeyIniciar.Text);
                }
            }
        }

        private void btnDefinirHotkeyParar_Click(object sender, EventArgs e)
        {
            using (HotkeyForm hk = new HotkeyForm())
            {
                if (hk.ShowDialog() == DialogResult.OK)
                {
                    txtHotkeyParar.Text = (hk.Ctrl ? "Ctrl+" : "") + (hk.Shift ? "Shift+" : "") + (hk.Alt ? "Alt+" : "") + hk.TeclaSelecionada.ToString();
                    
                    hotkeyParar = hk.TeclaSelecionada;
                    modifierParar = 0;
                    if (hk.Ctrl) modifierParar |= 0x0002;
                    if (hk.Shift) modifierParar |= 0x0004;
                    if (hk.Alt) modifierParar |= 0x0001;

                    ReRegistrarHotkeys();

                    IniHelper.Salvar("HotkeyParar", txtHotkeyParar.Text);
                }
            }
        }

        private void ReRegistrarHotkeys()
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID_START);
            UnregisterHotKey(this.Handle, HOTKEY_ID_STOP);

            RegisterHotKey(this.Handle, HOTKEY_ID_START, modifierIniciar, (uint)hotkeyIniciar);
            RegisterHotKey(this.Handle, HOTKEY_ID_STOP, modifierParar, (uint)hotkeyParar);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == HOTKEY_ID_START) btnIniciar.PerformClick();
                if (id == HOTKEY_ID_STOP) btnParar.PerformClick();
            }
            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            PararGravacao();
            UnregisterHotKey(this.Handle, HOTKEY_ID_START);
            UnregisterHotKey(this.Handle, HOTKEY_ID_STOP);
            base.OnFormClosing(e);
        }
    }
}
