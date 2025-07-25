namespace AptidaoMilitarDigital.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            txtBoxUsuario = new TextBox();
            txtBoxSenha = new TextBox();
            cBoxMostrarSenha = new CheckBox();
            cBoxLembrarMim = new CheckBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnLogin = new Button();
            btnSair = new Button();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 23);
            label1.Name = "label1";
            label1.Size = new Size(238, 38);
            label1.TabIndex = 0;
            label1.Text = "Efetue Seu Login";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.Location = new Point(106, 84);
            txtBoxUsuario.MaxLength = 50;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Digite o Usuário";
            txtBoxUsuario.Size = new Size(238, 34);
            txtBoxUsuario.TabIndex = 1;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.Location = new Point(106, 124);
            txtBoxSenha.MaxLength = 30;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Digite a Senha";
            txtBoxSenha.Size = new Size(238, 34);
            txtBoxSenha.TabIndex = 2;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.ForeColor = Color.FromArgb(209, 209, 209);
            cBoxMostrarSenha.Location = new Point(151, 164);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(148, 27);
            cBoxMostrarSenha.TabIndex = 3;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // cBoxLembrarMim
            // 
            cBoxLembrarMim.AutoSize = true;
            cBoxLembrarMim.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxLembrarMim.ForeColor = Color.FromArgb(209, 209, 209);
            cBoxLembrarMim.Location = new Point(141, 197);
            cBoxLembrarMim.Name = "cBoxLembrarMim";
            cBoxLembrarMim.Size = new Size(167, 27);
            cBoxLembrarMim.TabIndex = 4;
            cBoxLembrarMim.Text = "Lembrar de Mim";
            cBoxLembrarMim.UseVisualStyleBackColor = true;
            cBoxLembrarMim.CheckedChanged += cBoxLembrarMim_CheckedChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnLogin);
            flowLayoutPanel2.Controls.Add(btnSair);
            flowLayoutPanel2.Location = new Point(127, 230);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(195, 129);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(59, 154, 109);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(3, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(192, 54);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(209, 58, 58);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(3, 63);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(192, 54);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(450, 383);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(cBoxLembrarMim);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aptidão Militar Digital";
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxSenha;
        private CheckBox cBoxMostrarSenha;
        private CheckBox cBoxLembrarMim;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnLogin;
        private Button btnSair;
    }
}