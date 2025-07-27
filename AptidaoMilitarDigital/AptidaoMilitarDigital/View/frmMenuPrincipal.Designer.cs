namespace AptidaoMilitarDigital.View
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnNovo = new Button();
            btnExibir = new Button();
            btnRelatorio = new Button();
            btnConfig = new Button();
            btnSair = new Button();
            cBoxPatente = new ComboBox();
            txtBoxNomeGuerra = new TextBox();
            txtBoxIdade = new TextBox();
            cBoxSexo = new CheckedListBox();
            label3 = new Label();
            label4 = new Label();
            cBoxCarreira = new CheckedListBox();
            txtBoxCorrida = new TextBox();
            txtBoxNotaCorrida = new TextBox();
            txtBoxNotaFlexao = new TextBox();
            txtBoxFlexao = new TextBox();
            txtBoxNotaAbd = new TextBox();
            txtBoxAbd = new TextBox();
            txtBoxNotaBarra = new TextBox();
            txtBoxBarra = new TextBox();
            btnCadastro = new Button();
            btnLimpar = new Button();
            txtNomeGuerraPesquisar = new TextBox();
            cBoxPesquisarPatente = new ComboBox();
            btnPesquisar = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnNovo);
            flowLayoutPanel1.Controls.Add(btnExibir);
            flowLayoutPanel1.Controls.Add(btnRelatorio);
            flowLayoutPanel1.Controls.Add(btnConfig);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(241, 489);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 96);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(209, 209, 209);
            label2.Location = new Point(9, 58);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 1;
            label2.Text = "24/07/25 23:13";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(209, 209, 209);
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(52, 152, 219);
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(3, 105);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(207, 54);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnExibir
            // 
            btnExibir.BackColor = Color.FromArgb(52, 152, 219);
            btnExibir.FlatAppearance.BorderSize = 0;
            btnExibir.FlatStyle = FlatStyle.Flat;
            btnExibir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExibir.Location = new Point(3, 165);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(207, 54);
            btnExibir.TabIndex = 3;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = false;
            btnExibir.Click += btnExibir_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.FromArgb(52, 152, 219);
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorio.Location = new Point(3, 225);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(207, 54);
            btnRelatorio.TabIndex = 4;
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.Gray;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.Location = new Point(3, 285);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(207, 54);
            btnConfig.TabIndex = 5;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(209, 58, 58);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(3, 345);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(207, 54);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // cBoxPatente
            // 
            cBoxPatente.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxPatente.FlatStyle = FlatStyle.Flat;
            cBoxPatente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxPatente.Items.AddRange(new object[] { "Sd", "Cb", "Sgt", "Sub", "Ten", "Cap", "Maj", "Ten Cel", "Cel", "Gen" });
            cBoxPatente.Location = new Point(262, 116);
            cBoxPatente.Name = "cBoxPatente";
            cBoxPatente.Size = new Size(207, 36);
            cBoxPatente.TabIndex = 15;
            // 
            // txtBoxNomeGuerra
            // 
            txtBoxNomeGuerra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNomeGuerra.Location = new Point(262, 76);
            txtBoxNomeGuerra.MaxLength = 50;
            txtBoxNomeGuerra.Name = "txtBoxNomeGuerra";
            txtBoxNomeGuerra.PlaceholderText = "Nome de Guerra";
            txtBoxNomeGuerra.Size = new Size(207, 34);
            txtBoxNomeGuerra.TabIndex = 14;
            // 
            // txtBoxIdade
            // 
            txtBoxIdade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxIdade.Location = new Point(262, 158);
            txtBoxIdade.MaxLength = 50;
            txtBoxIdade.Name = "txtBoxIdade";
            txtBoxIdade.PlaceholderText = "Idade";
            txtBoxIdade.Size = new Size(207, 34);
            txtBoxIdade.TabIndex = 16;
            txtBoxIdade.KeyPress += txtBoxIdade_KeyPress;
            // 
            // cBoxSexo
            // 
            cBoxSexo.BackColor = Color.FromArgb(31, 31, 31);
            cBoxSexo.BorderStyle = BorderStyle.None;
            cBoxSexo.CheckOnClick = true;
            cBoxSexo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxSexo.ForeColor = Color.FromArgb(209, 209, 209);
            cBoxSexo.FormattingEnabled = true;
            cBoxSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cBoxSexo.Location = new Point(262, 236);
            cBoxSexo.Name = "cBoxSexo";
            cBoxSexo.Size = new Size(207, 58);
            cBoxSexo.TabIndex = 17;
            cBoxSexo.ItemCheck += cBoxSexo_ItemCheck;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(209, 209, 209);
            label3.Location = new Point(262, 205);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 18;
            label3.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(209, 209, 209);
            label4.Location = new Point(262, 298);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 20;
            label4.Text = "Carreira:";
            // 
            // cBoxCarreira
            // 
            cBoxCarreira.BackColor = Color.FromArgb(31, 31, 31);
            cBoxCarreira.BorderStyle = BorderStyle.None;
            cBoxCarreira.CheckOnClick = true;
            cBoxCarreira.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxCarreira.ForeColor = Color.FromArgb(209, 209, 209);
            cBoxCarreira.FormattingEnabled = true;
            cBoxCarreira.Items.AddRange(new object[] { "Sim", "Não" });
            cBoxCarreira.Location = new Point(262, 328);
            cBoxCarreira.Name = "cBoxCarreira";
            cBoxCarreira.Size = new Size(207, 58);
            cBoxCarreira.TabIndex = 19;
            cBoxCarreira.ItemCheck += cBoxCarreira_ItemCheck;
            // 
            // txtBoxCorrida
            // 
            txtBoxCorrida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCorrida.Location = new Point(515, 76);
            txtBoxCorrida.MaxLength = 50;
            txtBoxCorrida.Name = "txtBoxCorrida";
            txtBoxCorrida.PlaceholderText = "Corrida";
            txtBoxCorrida.Size = new Size(207, 34);
            txtBoxCorrida.TabIndex = 21;
            txtBoxCorrida.KeyPress += txtBoxIdade_KeyPress;
            // 
            // txtBoxNotaCorrida
            // 
            txtBoxNotaCorrida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNotaCorrida.Location = new Point(515, 116);
            txtBoxNotaCorrida.MaxLength = 50;
            txtBoxNotaCorrida.Name = "txtBoxNotaCorrida";
            txtBoxNotaCorrida.PlaceholderText = "Nota Corrida";
            txtBoxNotaCorrida.Size = new Size(207, 34);
            txtBoxNotaCorrida.TabIndex = 22;
            // 
            // txtBoxNotaFlexao
            // 
            txtBoxNotaFlexao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNotaFlexao.Location = new Point(515, 196);
            txtBoxNotaFlexao.MaxLength = 50;
            txtBoxNotaFlexao.Name = "txtBoxNotaFlexao";
            txtBoxNotaFlexao.PlaceholderText = "Nota Flexão";
            txtBoxNotaFlexao.Size = new Size(207, 34);
            txtBoxNotaFlexao.TabIndex = 24;
            // 
            // txtBoxFlexao
            // 
            txtBoxFlexao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxFlexao.Location = new Point(515, 156);
            txtBoxFlexao.MaxLength = 50;
            txtBoxFlexao.Name = "txtBoxFlexao";
            txtBoxFlexao.PlaceholderText = "Flexão";
            txtBoxFlexao.Size = new Size(207, 34);
            txtBoxFlexao.TabIndex = 23;
            txtBoxFlexao.KeyPress += txtBoxIdade_KeyPress;
            // 
            // txtBoxNotaAbd
            // 
            txtBoxNotaAbd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNotaAbd.Location = new Point(515, 276);
            txtBoxNotaAbd.MaxLength = 50;
            txtBoxNotaAbd.Name = "txtBoxNotaAbd";
            txtBoxNotaAbd.PlaceholderText = "Nota Abdominal";
            txtBoxNotaAbd.Size = new Size(207, 34);
            txtBoxNotaAbd.TabIndex = 26;
            // 
            // txtBoxAbd
            // 
            txtBoxAbd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAbd.Location = new Point(515, 236);
            txtBoxAbd.MaxLength = 50;
            txtBoxAbd.Name = "txtBoxAbd";
            txtBoxAbd.PlaceholderText = "Abdominal";
            txtBoxAbd.Size = new Size(207, 34);
            txtBoxAbd.TabIndex = 25;
            txtBoxAbd.KeyPress += txtBoxIdade_KeyPress;
            // 
            // txtBoxNotaBarra
            // 
            txtBoxNotaBarra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNotaBarra.Location = new Point(515, 356);
            txtBoxNotaBarra.MaxLength = 50;
            txtBoxNotaBarra.Name = "txtBoxNotaBarra";
            txtBoxNotaBarra.PlaceholderText = "Nota Barra";
            txtBoxNotaBarra.Size = new Size(207, 34);
            txtBoxNotaBarra.TabIndex = 28;
            // 
            // txtBoxBarra
            // 
            txtBoxBarra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBarra.Location = new Point(515, 316);
            txtBoxBarra.MaxLength = 50;
            txtBoxBarra.Name = "txtBoxBarra";
            txtBoxBarra.PlaceholderText = "Barra";
            txtBoxBarra.Size = new Size(207, 34);
            txtBoxBarra.TabIndex = 27;
            txtBoxBarra.KeyPress += txtBoxIdade_KeyPress;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.FromArgb(59, 154, 109);
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.Location = new Point(515, 405);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(207, 54);
            btnCadastro.TabIndex = 29;
            btnCadastro.Text = "Salvar";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(209, 58, 58);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(262, 405);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(207, 54);
            btnLimpar.TabIndex = 30;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtNomeGuerraPesquisar
            // 
            txtNomeGuerraPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeGuerraPesquisar.Location = new Point(354, 14);
            txtNomeGuerraPesquisar.MaxLength = 50;
            txtNomeGuerraPesquisar.Name = "txtNomeGuerraPesquisar";
            txtNomeGuerraPesquisar.PlaceholderText = "Nome de Guerra";
            txtNomeGuerraPesquisar.Size = new Size(219, 34);
            txtNomeGuerraPesquisar.TabIndex = 31;
            // 
            // cBoxPesquisarPatente
            // 
            cBoxPesquisarPatente.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxPesquisarPatente.FlatStyle = FlatStyle.Flat;
            cBoxPesquisarPatente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxPesquisarPatente.FormattingEnabled = true;
            cBoxPesquisarPatente.Items.AddRange(new object[] { "Sd", "Cb", "Sgt", "Sub", "Ten", "Cap", "Maj", "Ten Cel", "Cel", "Gen" });
            cBoxPesquisarPatente.Location = new Point(262, 12);
            cBoxPesquisarPatente.Name = "cBoxPesquisarPatente";
            cBoxPesquisarPatente.Size = new Size(86, 36);
            cBoxPesquisarPatente.TabIndex = 32;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Gray;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(579, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(143, 36);
            btnPesquisar.TabIndex = 33;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(800, 461);
            Controls.Add(btnPesquisar);
            Controls.Add(cBoxPesquisarPatente);
            Controls.Add(txtNomeGuerraPesquisar);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastro);
            Controls.Add(txtBoxNotaBarra);
            Controls.Add(txtBoxBarra);
            Controls.Add(txtBoxNotaAbd);
            Controls.Add(txtBoxAbd);
            Controls.Add(txtBoxNotaFlexao);
            Controls.Add(txtBoxFlexao);
            Controls.Add(txtBoxNotaCorrida);
            Controls.Add(txtBoxCorrida);
            Controls.Add(label4);
            Controls.Add(cBoxCarreira);
            Controls.Add(label3);
            Controls.Add(cBoxSexo);
            Controls.Add(txtBoxIdade);
            Controls.Add(cBoxPatente);
            Controls.Add(txtBoxNomeGuerra);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aptidão Militar Digital";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button btnNovo;
        private Button btnExibir;
        private Button btnRelatorio;
        private Button btnConfig;
        private Button btnSair;
        private ComboBox cBoxPatente;
        private TextBox txtBoxNomeGuerra;
        private TextBox txtBoxIdade;
        private CheckedListBox cBoxSexo;
        private Label label3;
        private Label label4;
        private CheckedListBox cBoxCarreira;
        private TextBox txtBoxCorrida;
        private TextBox txtBoxNotaCorrida;
        private TextBox txtBoxNotaFlexao;
        private TextBox txtBoxFlexao;
        private TextBox txtBoxNotaAbd;
        private TextBox txtBoxAbd;
        private TextBox txtBoxNotaBarra;
        private TextBox txtBoxBarra;
        private Button btnCadastro;
        private Button btnLimpar;
        private TextBox txtNomeGuerraPesquisar;
        private ComboBox cBoxPesquisarPatente;
        private Button btnPesquisar;
    }
}