namespace AptidaoMilitarDigital.View
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnCadastro = new Button();
            btnSair = new Button();
            cBoxMostrarSenha = new CheckBox();
            txtBoxSenha = new TextBox();
            txtBoxUsuario = new TextBox();
            label1 = new Label();
            txtBoxNomeGuerra = new TextBox();
            cBoxPatente = new ComboBox();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnCadastro);
            flowLayoutPanel2.Controls.Add(btnSair);
            flowLayoutPanel2.Location = new Point(127, 259);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(195, 129);
            flowLayoutPanel2.TabIndex = 11;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.FromArgb(59, 154, 109);
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.Location = new Point(3, 3);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(192, 54);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
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
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.ForeColor = Color.FromArgb(209, 209, 209);
            cBoxMostrarSenha.Location = new Point(151, 226);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(148, 27);
            cBoxMostrarSenha.TabIndex = 9;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.Location = new Point(106, 186);
            txtBoxSenha.MaxLength = 30;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Digite a Senha";
            txtBoxSenha.Size = new Size(238, 34);
            txtBoxSenha.TabIndex = 8;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.Location = new Point(106, 64);
            txtBoxUsuario.MaxLength = 50;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Digite o Usuário";
            txtBoxUsuario.Size = new Size(238, 34);
            txtBoxUsuario.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, 23);
            label1.Name = "label1";
            label1.Size = new Size(280, 38);
            label1.TabIndex = 6;
            label1.Text = "Efetue Seu Cadastro";
            // 
            // txtBoxNomeGuerra
            // 
            txtBoxNomeGuerra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNomeGuerra.Location = new Point(106, 104);
            txtBoxNomeGuerra.MaxLength = 50;
            txtBoxNomeGuerra.Name = "txtBoxNomeGuerra";
            txtBoxNomeGuerra.PlaceholderText = "Nome de Guerra";
            txtBoxNomeGuerra.Size = new Size(238, 34);
            txtBoxNomeGuerra.TabIndex = 12;
            // 
            // cBoxPatente
            // 
            cBoxPatente.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxPatente.FlatStyle = FlatStyle.Flat;
            cBoxPatente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxPatente.FormattingEnabled = true;
            cBoxPatente.Items.AddRange(new object[] { "Soldado", "Cabo", "Sargento", "Sub-Tenente", "Tenente", "Capitão", "Major", "Tenente-Coronel", "Coronel", "General" });
            cBoxPatente.Location = new Point(106, 144);
            cBoxPatente.Name = "cBoxPatente";
            cBoxPatente.Size = new Size(238, 36);
            cBoxPatente.TabIndex = 13;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(450, 413);
            Controls.Add(cBoxPatente);
            Controls.Add(txtBoxNomeGuerra);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aptidão Militar Digital";
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnCadastro;
        private Button btnSair;
        private CheckBox cBoxMostrarSenha;
        private TextBox txtBoxSenha;
        private TextBox txtBoxUsuario;
        private Label label1;
        private TextBox txtBoxNomeGuerra;
        private ComboBox cBoxPatente;
    }
}