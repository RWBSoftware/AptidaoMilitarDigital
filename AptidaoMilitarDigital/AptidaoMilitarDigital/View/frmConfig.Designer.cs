namespace AptidaoMilitarDigital.View
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            btnMudarSenha = new Button();
            btnTrocarConta = new Button();
            btnSair = new Button();
            btnAvaliacao = new Button();
            SuspendLayout();
            // 
            // btnMudarSenha
            // 
            btnMudarSenha.BackColor = Color.FromArgb(59, 154, 109);
            btnMudarSenha.FlatAppearance.BorderSize = 0;
            btnMudarSenha.FlatStyle = FlatStyle.Flat;
            btnMudarSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMudarSenha.Location = new Point(76, 12);
            btnMudarSenha.Name = "btnMudarSenha";
            btnMudarSenha.Size = new Size(207, 54);
            btnMudarSenha.TabIndex = 7;
            btnMudarSenha.Text = "Mudar Senha";
            btnMudarSenha.UseVisualStyleBackColor = false;
            btnMudarSenha.Click += btnMudarSenha_Click;
            // 
            // btnTrocarConta
            // 
            btnTrocarConta.BackColor = Color.FromArgb(59, 154, 109);
            btnTrocarConta.FlatAppearance.BorderSize = 0;
            btnTrocarConta.FlatStyle = FlatStyle.Flat;
            btnTrocarConta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrocarConta.Location = new Point(76, 72);
            btnTrocarConta.Name = "btnTrocarConta";
            btnTrocarConta.Size = new Size(207, 54);
            btnTrocarConta.TabIndex = 8;
            btnTrocarConta.Text = "Trocar Conta";
            btnTrocarConta.UseVisualStyleBackColor = false;
            btnTrocarConta.Click += btnTrocarConta_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(209, 58, 58);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(76, 192);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(207, 54);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnAvaliacao
            // 
            btnAvaliacao.BackColor = Color.FromArgb(59, 154, 109);
            btnAvaliacao.FlatAppearance.BorderSize = 0;
            btnAvaliacao.FlatStyle = FlatStyle.Flat;
            btnAvaliacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvaliacao.Location = new Point(76, 132);
            btnAvaliacao.Name = "btnAvaliacao";
            btnAvaliacao.Size = new Size(207, 54);
            btnAvaliacao.TabIndex = 12;
            btnAvaliacao.Text = "Avaliação";
            btnAvaliacao.UseVisualStyleBackColor = false;
            btnAvaliacao.Click += btnAvaliacao_Click;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(360, 263);
            Controls.Add(btnAvaliacao);
            Controls.Add(btnMudarSenha);
            Controls.Add(btnTrocarConta);
            Controls.Add(btnSair);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aptidão Militar Digital";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMudarSenha;
        private Button btnTrocarConta;
        private Button btnSair;
        private Button btnAvaliacao;
    }
}