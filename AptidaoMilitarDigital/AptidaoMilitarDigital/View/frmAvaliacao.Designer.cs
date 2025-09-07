namespace AptidaoMilitarDigital.View
{
    partial class frmAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvaliacao));
            txtDescricao = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnEnviar = new Button();
            btnVoltar = new Button();
            txtNota = new TextBox();
            label1 = new Label();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(106, 105);
            txtDescricao.MaxLength = 500;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição...";
            txtDescricao.Size = new Size(238, 148);
            txtDescricao.TabIndex = 19;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnEnviar);
            flowLayoutPanel2.Controls.Add(btnVoltar);
            flowLayoutPanel2.Location = new Point(127, 259);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(195, 129);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(59, 154, 109);
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(3, 3);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(192, 54);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(209, 58, 58);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(3, 63);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(192, 54);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.Location = new Point(106, 64);
            txtNota.MaxLength = 1;
            txtNota.Name = "txtNota";
            txtNota.PlaceholderText = "Nota(0-5)";
            txtNota.Size = new Size(238, 34);
            txtNota.TabIndex = 15;
            txtNota.KeyPress += txtNota_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 23);
            label1.Name = "label1";
            label1.Size = new Size(306, 38);
            label1.TabIndex = 14;
            label1.Text = "Avalie sua experiência";
            // 
            // frmAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(450, 413);
            Controls.Add(txtDescricao);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(txtNota);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAvaliacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aptidão Militar Digital";
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBoxPatente;
        private TextBox txtDescricao;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnEnviar;
        private Button btnVoltar;
        private CheckBox cBoxMostrarSenha;
        private TextBox txtBoxSenha;
        private TextBox txtNota;
        private Label label1;
    }
}