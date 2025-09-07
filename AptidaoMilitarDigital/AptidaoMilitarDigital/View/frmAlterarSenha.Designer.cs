namespace AptidaoMilitarDigital.View
{
    partial class frmAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarSenha));
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAlterar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            cBoxMostrarSenha = new CheckBox();
            txtSenhaNovaNovamente = new TextBox();
            label1 = new Label();
            txtSenhaNova = new TextBox();
            txtSenhaAtual = new TextBox();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnAlterar);
            flowLayoutPanel2.Controls.Add(btnLimpar);
            flowLayoutPanel2.Controls.Add(btnSair);
            flowLayoutPanel2.Location = new Point(127, 217);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(195, 187);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(59, 154, 109);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(3, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(192, 54);
            btnAlterar.TabIndex = 0;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(209, 58, 58);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(3, 63);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(192, 54);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(209, 58, 58);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(3, 123);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(192, 54);
            btnSair.TabIndex = 2;
            btnSair.Text = "Voltar";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.ForeColor = Color.FromArgb(209, 209, 209);
            cBoxMostrarSenha.Location = new Point(151, 184);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(148, 27);
            cBoxMostrarSenha.TabIndex = 17;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // txtSenhaNovaNovamente
            // 
            txtSenhaNovaNovamente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaNovaNovamente.Location = new Point(106, 144);
            txtSenhaNovaNovamente.MaxLength = 30;
            txtSenhaNovaNovamente.Name = "txtSenhaNovaNovamente";
            txtSenhaNovaNovamente.PlaceholderText = "Nova Senha Novamente";
            txtSenhaNovaNovamente.Size = new Size(238, 34);
            txtSenhaNovaNovamente.TabIndex = 16;
            txtSenhaNovaNovamente.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 38);
            label1.TabIndex = 14;
            label1.Text = "Alterar Senha";
            // 
            // txtSenhaNova
            // 
            txtSenhaNova.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaNova.Location = new Point(106, 104);
            txtSenhaNova.MaxLength = 30;
            txtSenhaNova.Name = "txtSenhaNova";
            txtSenhaNova.PlaceholderText = "Nova Senha";
            txtSenhaNova.Size = new Size(238, 34);
            txtSenhaNova.TabIndex = 19;
            txtSenhaNova.UseSystemPasswordChar = true;
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaAtual.Location = new Point(106, 64);
            txtSenhaAtual.MaxLength = 30;
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.PlaceholderText = "Senha Atual";
            txtSenhaAtual.Size = new Size(238, 34);
            txtSenhaAtual.TabIndex = 20;
            txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // frmAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(450, 423);
            Controls.Add(txtSenhaAtual);
            Controls.Add(txtSenhaNova);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(txtSenhaNovaNovamente);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAlterarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aptidão Militar Digital";
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAlterar;
        private Button btnSair;
        private CheckBox cBoxMostrarSenha;
        private TextBox txtSenhaNovaNovamente;
        private Label label1;
        private TextBox txtSenhaNova;
        private TextBox txtSenhaAtual;
        private Button btnLimpar;
    }
}