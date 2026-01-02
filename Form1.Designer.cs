namespace GravadorAudioSaidaWin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbDispositivos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar prgVolume;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbDispositivos = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnTeste = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.prgVolume = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // cmbDispositivos
            // 
            this.cmbDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispositivos.FormattingEnabled = true;
            this.cmbDispositivos.Location = new System.Drawing.Point(12, 12);
            this.cmbDispositivos.Name = "cmbDispositivos";
            this.cmbDispositivos.Size = new System.Drawing.Size(360, 23);
            this.cmbDispositivos.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 45);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(110, 30);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(132, 45);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(110, 30);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(252, 45);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 30);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // prgVolume
            // 
            this.prgVolume.Location = new System.Drawing.Point(12, 85);
            this.prgVolume.Maximum = 100;
            this.prgVolume.Name = "prgVolume";
            this.prgVolume.Size = new System.Drawing.Size(360, 18);
            this.prgVolume.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 112);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 15);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Aguardando";
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(12, 145);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(360, 30);
            this.btnTeste.TabIndex = 6;
            this.btnTeste.Text = "Testar áudio padrão";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 200);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.prgVolume);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbDispositivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gravador de Saída de Áudio";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}