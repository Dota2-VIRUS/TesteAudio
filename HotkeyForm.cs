using System;
using System.Windows.Forms;

namespace GravadorAudioSaidaWin
{
    public class HotkeyForm : Form
    {
        public Keys TeclaSelecionada { get; private set; }
        public bool Shift { get; private set; }
        public bool Ctrl { get; private set; }
        public bool Alt { get; private set; }

        private Label lblInstrucao;
        private Button btnConfirmar;

        private Keys teclaAtual = Keys.None;

        public HotkeyForm()
        {
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.Text = "Pressione a Hotkey";
            this.StartPosition = FormStartPosition.CenterParent;

            lblInstrucao = new Label();
            lblInstrucao.Text = "Pressione a combinação de teclas e clique em Confirmar";
            lblInstrucao.Dock = DockStyle.Top;
            lblInstrucao.Height = 40;
            lblInstrucao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(lblInstrucao);

            btnConfirmar = new Button();
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Width = 100;
            btnConfirmar.Height = 30;
            btnConfirmar.Top = 60;
            btnConfirmar.Left = (this.ClientSize.Width - btnConfirmar.Width) / 2;
            btnConfirmar.Click += BtnConfirmar_Click;
            this.Controls.Add(btnConfirmar);

            this.KeyPreview = true;
            this.KeyDown += HotkeyForm_KeyDown;
            this.KeyUp += HotkeyForm_KeyUp;
        }

        private void HotkeyForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Atualiza modificadores
            Shift = e.Shift;
            Ctrl = e.Control;
            Alt = e.Alt;

            // Ignora apenas teclas modificadoras
            if (e.KeyCode != Keys.ShiftKey && e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Menu)
            {
                teclaAtual = e.KeyCode;
                lblInstrucao.Text = $"Hotkey: {(Ctrl ? "Ctrl+" : "")}{(Shift ? "Shift+" : "")}{(Alt ? "Alt+" : "")}{teclaAtual}";
            }
        }

        private void HotkeyForm_KeyUp(object sender, KeyEventArgs e)
        {
            // Apenas para manter o lbl atualizado se liberar alguma tecla
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            TeclaSelecionada = teclaAtual;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
