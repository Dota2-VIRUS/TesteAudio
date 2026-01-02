namespace GravadorAudioSaidaWin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbDispositivos;
        private System.Windows.Forms.ProgressBar prgVolume;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.Label lblExe;
        private System.Windows.Forms.TextBox txtExecutavel;
        private System.Windows.Forms.Button btnSelecionarExe;

        private System.Windows.Forms.GroupBox grpHotkeys;
        private System.Windows.Forms.Label lblIniciar;
        private System.Windows.Forms.Label lblParar;
        private System.Windows.Forms.TextBox txtHotkeyIniciar;
        private System.Windows.Forms.TextBox txtHotkeyParar;
        private System.Windows.Forms.Button btnDefinirHotkeyIniciar;
        private System.Windows.Forms.Button btnDefinirHotkeyParar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbDispositivos = new System.Windows.Forms.ComboBox();
            this.prgVolume = new System.Windows.Forms.ProgressBar();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();

            this.lblExe = new System.Windows.Forms.Label();
            this.txtExecutavel = new System.Windows.Forms.TextBox();
            this.btnSelecionarExe = new System.Windows.Forms.Button();

            this.grpHotkeys = new System.Windows.Forms.GroupBox();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.lblParar = new System.Windows.Forms.Label();
            this.txtHotkeyIniciar = new System.Windows.Forms.TextBox();
            this.txtHotkeyParar = new System.Windows.Forms.TextBox();
            this.btnDefinirHotkeyIniciar = new System.Windows.Forms.Button();
            this.btnDefinirHotkeyParar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // cmbDispositivos
            this.cmbDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispositivos.Location = new System.Drawing.Point(12, 12);
            this.cmbDispositivos.Size = new System.Drawing.Size(300, 23);

            // prgVolume
            this.prgVolume.Location = new System.Drawing.Point(12, 40);
            this.prgVolume.Size = new System.Drawing.Size(300, 23);

            // btnIniciar
            this.btnIniciar.Location = new System.Drawing.Point(12, 70);
            this.btnIniciar.Size = new System.Drawing.Size(75, 30);
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);

            // btnParar
            this.btnParar.Location = new System.Drawing.Point(100, 70);
            this.btnParar.Size = new System.Drawing.Size(75, 30);
            this.btnParar.Text = "Parar";
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);

            // btnTeste
            this.btnTeste.Location = new System.Drawing.Point(190, 70);
            this.btnTeste.Size = new System.Drawing.Size(75, 30);
            this.btnTeste.Text = "Teste";
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);

            // btnAtualizar
            this.btnAtualizar.Location = new System.Drawing.Point(280, 70);
            this.btnAtualizar.Size = new System.Drawing.Size(75, 30);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            // lblStatus
            this.lblStatus.Location = new System.Drawing.Point(12, 110);
            this.lblStatus.Size = new System.Drawing.Size(300, 23);
            this.lblStatus.Text = "Status";

            // lblExe
            this.lblExe.Location = new System.Drawing.Point(12, 140);
            this.lblExe.Size = new System.Drawing.Size(80, 23);
            this.lblExe.Text = "Executável:";

            // txtExecutavel
            this.txtExecutavel.Location = new System.Drawing.Point(100, 140);
            this.txtExecutavel.Size = new System.Drawing.Size(200, 23);
            this.txtExecutavel.ReadOnly = true;

            // btnSelecionarExe
            this.btnSelecionarExe.Location = new System.Drawing.Point(310, 140);
            this.btnSelecionarExe.Size = new System.Drawing.Size(100, 30);
            this.btnSelecionarExe.Text = "Selecionar";
            this.btnSelecionarExe.Click += new System.EventHandler(this.btnSelecionarExe_Click);

            // grpHotkeys
            this.grpHotkeys.Text = "Hotkeys";
            this.grpHotkeys.Location = new System.Drawing.Point(12, 170);
            this.grpHotkeys.Size = new System.Drawing.Size(380, 100);
            this.grpHotkeys.Padding = new System.Windows.Forms.Padding(10);

            // lblIniciar
            this.lblIniciar.Text = "Iniciar:";
            this.lblIniciar.Location = new System.Drawing.Point(15, 30);
            this.lblIniciar.AutoSize = true;

            // lblParar
            this.lblParar.Text = "Parar:";
            this.lblParar.Location = new System.Drawing.Point(15, 55);
            this.lblParar.AutoSize = true;

            // txtHotkeyIniciar
            this.txtHotkeyIniciar.Location = new System.Drawing.Point(70, 27);
            this.txtHotkeyIniciar.Size = new System.Drawing.Size(150, 23);
            this.txtHotkeyIniciar.ReadOnly = true;

            // txtHotkeyParar
            this.txtHotkeyParar.Location = new System.Drawing.Point(70, 52);
            this.txtHotkeyParar.Size = new System.Drawing.Size(150, 23);
            this.txtHotkeyParar.ReadOnly = true;

            // btnDefinirHotkeyIniciar
            this.btnDefinirHotkeyIniciar.Text = "Definir";
            this.btnDefinirHotkeyIniciar.Location = new System.Drawing.Point(230, 27);
            this.btnDefinirHotkeyIniciar.Size = new System.Drawing.Size(75, 30);
            this.btnDefinirHotkeyIniciar.Click += new System.EventHandler(this.btnDefinirHotkeyIniciar_Click);

            // btnDefinirHotkeyParar
            this.btnDefinirHotkeyParar.Text = "Definir";
            this.btnDefinirHotkeyParar.Location = new System.Drawing.Point(230, 52);
            this.btnDefinirHotkeyParar.Size = new System.Drawing.Size(75, 30);
            this.btnDefinirHotkeyParar.Click += new System.EventHandler(this.btnDefinirHotkeyParar_Click);

            // Adicionando controles ao GroupBox
            this.grpHotkeys.Controls.Add(this.lblIniciar);
            this.grpHotkeys.Controls.Add(this.txtHotkeyIniciar);
            this.grpHotkeys.Controls.Add(this.btnDefinirHotkeyIniciar);
            this.grpHotkeys.Controls.Add(this.lblParar);
            this.grpHotkeys.Controls.Add(this.txtHotkeyParar);
            this.grpHotkeys.Controls.Add(this.btnDefinirHotkeyParar);

            // Adicionando controles ao Form
            this.Controls.Add(this.cmbDispositivos);
            this.Controls.Add(this.prgVolume);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblExe);
            this.Controls.Add(this.txtExecutavel);
            this.Controls.Add(this.btnSelecionarExe);
            this.Controls.Add(this.grpHotkeys);

            this.ClientSize = new System.Drawing.Size(420, 270);
            this.Text = "Gravador de Áudio da Saída";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
