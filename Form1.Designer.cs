namespace GravadorAudioSaidaWin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelDispositivo;
        private System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.ComboBox cmbDispositivos;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panelVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ProgressBar prgVolume;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpExecutavel;
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelDispositivo = new System.Windows.Forms.Panel();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.cmbDispositivos = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panelVolume = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.prgVolume = new System.Windows.Forms.ProgressBar();
            this.panelControles = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnTeste = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpExecutavel = new System.Windows.Forms.GroupBox();
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

            this.panelHeader.SuspendLayout();
            this.panelDispositivo.SuspendLayout();
            this.panelVolume.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.grpExecutavel.SuspendLayout();
            this.grpHotkeys.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Size = new System.Drawing.Size(520, 60);
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 17);
            this.lblTitulo.Text = "🎵 Gravador de Áudio da Saída";

            // 
            // panelDispositivo
            // 
            this.panelDispositivo.BackColor = System.Drawing.Color.White;
            this.panelDispositivo.Controls.Add(this.lblDispositivo);
            this.panelDispositivo.Controls.Add(this.cmbDispositivos);
            this.panelDispositivo.Controls.Add(this.btnAtualizar);
            this.panelDispositivo.Location = new System.Drawing.Point(20, 75);
            this.panelDispositivo.Size = new System.Drawing.Size(480, 70);
            this.panelDispositivo.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);

            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDispositivo.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblDispositivo.Location = new System.Drawing.Point(10, 8);
            this.lblDispositivo.Text = "Dispositivo de Áudio";

            // 
            // cmbDispositivos
            // 
            this.cmbDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispositivos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDispositivos.Location = new System.Drawing.Point(10, 30);
            this.cmbDispositivos.Size = new System.Drawing.Size(350, 25);

            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnAtualizar.Location = new System.Drawing.Point(370, 28);
            this.btnAtualizar.Size = new System.Drawing.Size(95, 30);
            this.btnAtualizar.Text = "🔄 Atualizar";
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            // 
            // panelVolume
            // 
            this.panelVolume.BackColor = System.Drawing.Color.White;
            this.panelVolume.Controls.Add(this.lblVolume);
            this.panelVolume.Controls.Add(this.prgVolume);
            this.panelVolume.Location = new System.Drawing.Point(20, 155);
            this.panelVolume.Size = new System.Drawing.Size(480, 60);
            this.panelVolume.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);

            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVolume.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblVolume.Location = new System.Drawing.Point(10, 8);
            this.lblVolume.Text = "Nível de Volume";

            // 
            // prgVolume
            // 
            this.prgVolume.Location = new System.Drawing.Point(10, 30);
            this.prgVolume.Size = new System.Drawing.Size(455, 20);
            this.prgVolume.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgVolume.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);

            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.White;
            this.panelControles.Controls.Add(this.btnIniciar);
            this.panelControles.Controls.Add(this.btnParar);
            this.panelControles.Controls.Add(this.btnTeste);
            this.panelControles.Location = new System.Drawing.Point(20, 225);
            this.panelControles.Size = new System.Drawing.Size(480, 60);
            this.panelControles.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);

            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(10, 12);
            this.btnIniciar.Size = new System.Drawing.Size(140, 40);
            this.btnIniciar.Text = "▶ Iniciar";
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);

            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.FlatAppearance.BorderSize = 0;
            this.btnParar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnParar.ForeColor = System.Drawing.Color.White;
            this.btnParar.Location = new System.Drawing.Point(165, 12);
            this.btnParar.Size = new System.Drawing.Size(140, 40);
            this.btnParar.Text = "⏹ Parar";
            this.btnParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);

            // 
            // btnTeste
            // 
            this.btnTeste.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeste.FlatAppearance.BorderSize = 0;
            this.btnTeste.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTeste.ForeColor = System.Drawing.Color.White;
            this.btnTeste.Location = new System.Drawing.Point(320, 12);
            this.btnTeste.Size = new System.Drawing.Size(145, 40);
            this.btnTeste.Text = "🧪 Teste";
            this.btnTeste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);

            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(255, 244, 206);
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Location = new System.Drawing.Point(20, 295);
            this.panelStatus.Size = new System.Drawing.Size(480, 40);
            this.panelStatus.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);

            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(102, 81, 0);
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Text = "● Aguardando...";

            // 
            // grpExecutavel
            // 
            this.grpExecutavel.BackColor = System.Drawing.Color.White;
            this.grpExecutavel.Controls.Add(this.lblExe);
            this.grpExecutavel.Controls.Add(this.txtExecutavel);
            this.grpExecutavel.Controls.Add(this.btnSelecionarExe);
            this.grpExecutavel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpExecutavel.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.grpExecutavel.Location = new System.Drawing.Point(20, 345);
            this.grpExecutavel.Size = new System.Drawing.Size(480, 80);
            this.grpExecutavel.Padding = new System.Windows.Forms.Padding(15);
            this.grpExecutavel.Text = "Filtro por Aplicativo";

            // 
            // lblExe
            // 
            this.lblExe.AutoSize = true;
            this.lblExe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExe.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblExe.Location = new System.Drawing.Point(15, 28);
            this.lblExe.Text = "Aplicativo:";

            // 
            // txtExecutavel
            // 
            this.txtExecutavel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExecutavel.Location = new System.Drawing.Point(15, 48);
            this.txtExecutavel.Size = new System.Drawing.Size(320, 25);
            this.txtExecutavel.ReadOnly = true;
            this.txtExecutavel.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            // 
            // btnSelecionarExe
            // 
            this.btnSelecionarExe.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSelecionarExe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarExe.FlatAppearance.BorderSize = 0;
            this.btnSelecionarExe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelecionarExe.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarExe.Location = new System.Drawing.Point(345, 45);
            this.btnSelecionarExe.Size = new System.Drawing.Size(120, 30);
            this.btnSelecionarExe.Text = "📁 Selecionar";
            this.btnSelecionarExe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarExe.Click += new System.EventHandler(this.btnSelecionarExe_Click);

            // 
            // grpHotkeys
            // 
            this.grpHotkeys.BackColor = System.Drawing.Color.White;
            this.grpHotkeys.Controls.Add(this.lblIniciar);
            this.grpHotkeys.Controls.Add(this.txtHotkeyIniciar);
            this.grpHotkeys.Controls.Add(this.btnDefinirHotkeyIniciar);
            this.grpHotkeys.Controls.Add(this.lblParar);
            this.grpHotkeys.Controls.Add(this.txtHotkeyParar);
            this.grpHotkeys.Controls.Add(this.btnDefinirHotkeyParar);
            this.grpHotkeys.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpHotkeys.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.grpHotkeys.Location = new System.Drawing.Point(20, 435);
            this.grpHotkeys.Size = new System.Drawing.Size(480, 100);
            this.grpHotkeys.Padding = new System.Windows.Forms.Padding(15);
            this.grpHotkeys.Text = "Atalhos de Teclado";

            // 
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIniciar.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblIniciar.Location = new System.Drawing.Point(15, 30);
            this.lblIniciar.Text = "Iniciar:";

            // 
            // txtHotkeyIniciar
            // 
            this.txtHotkeyIniciar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHotkeyIniciar.Location = new System.Drawing.Point(80, 27);
            this.txtHotkeyIniciar.Size = new System.Drawing.Size(255, 25);
            this.txtHotkeyIniciar.ReadOnly = true;
            this.txtHotkeyIniciar.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.txtHotkeyIniciar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // btnDefinirHotkeyIniciar
            // 
            this.btnDefinirHotkeyIniciar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnDefinirHotkeyIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefinirHotkeyIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnDefinirHotkeyIniciar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDefinirHotkeyIniciar.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnDefinirHotkeyIniciar.Location = new System.Drawing.Point(345, 25);
            this.btnDefinirHotkeyIniciar.Size = new System.Drawing.Size(120, 30);
            this.btnDefinirHotkeyIniciar.Text = "⌨ Definir";
            this.btnDefinirHotkeyIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefinirHotkeyIniciar.Click += new System.EventHandler(this.btnDefinirHotkeyIniciar_Click);

            // 
            // lblParar
            // 
            this.lblParar.AutoSize = true;
            this.lblParar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblParar.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblParar.Location = new System.Drawing.Point(15, 62);
            this.lblParar.Text = "Parar:";

            // 
            // txtHotkeyParar
            // 
            this.txtHotkeyParar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHotkeyParar.Location = new System.Drawing.Point(80, 59);
            this.txtHotkeyParar.Size = new System.Drawing.Size(255, 25);
            this.txtHotkeyParar.ReadOnly = true;
            this.txtHotkeyParar.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.txtHotkeyParar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // btnDefinirHotkeyParar
            // 
            this.btnDefinirHotkeyParar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnDefinirHotkeyParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefinirHotkeyParar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnDefinirHotkeyParar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDefinirHotkeyParar.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnDefinirHotkeyParar.Location = new System.Drawing.Point(345, 57);
            this.btnDefinirHotkeyParar.Size = new System.Drawing.Size(120, 30);
            this.btnDefinirHotkeyParar.Text = "⌨ Definir";
            this.btnDefinirHotkeyParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefinirHotkeyParar.Click += new System.EventHandler(this.btnDefinirHotkeyParar_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(520, 550);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gravador de Áudio";
            
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelDispositivo);
            this.Controls.Add(this.panelVolume);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.grpExecutavel);
            this.Controls.Add(this.grpHotkeys);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDispositivo.ResumeLayout(false);
            this.panelDispositivo.PerformLayout();
            this.panelVolume.ResumeLayout(false);
            this.panelVolume.PerformLayout();
            this.panelControles.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.grpExecutavel.ResumeLayout(false);
            this.grpExecutavel.PerformLayout();
            this.grpHotkeys.ResumeLayout(false);
            this.grpHotkeys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}