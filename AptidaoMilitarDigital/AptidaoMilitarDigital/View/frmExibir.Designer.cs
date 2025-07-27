namespace AptidaoMilitarDigital.View
{
    partial class frmExibir
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExibir));
            dataGridView1 = new DataGridView();
            btnPesquisar = new Button();
            cBoxPesquisarPatente = new ComboBox();
            txtNomeGuerraPesquisar = new TextBox();
            btnLimpar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(31, 31, 31);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 396);
            dataGridView1.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Gray;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(329, 11);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(143, 36);
            btnPesquisar.TabIndex = 36;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // cBoxPesquisarPatente
            // 
            cBoxPesquisarPatente.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxPesquisarPatente.FlatStyle = FlatStyle.Flat;
            cBoxPesquisarPatente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxPesquisarPatente.FormattingEnabled = true;
            cBoxPesquisarPatente.Items.AddRange(new object[] { "Sd", "Cb", "Sgt", "Sub", "Ten", "Cap", "Maj", "Ten Cel", "Cel", "Gen" });
            cBoxPesquisarPatente.Location = new Point(12, 12);
            cBoxPesquisarPatente.Name = "cBoxPesquisarPatente";
            cBoxPesquisarPatente.Size = new Size(86, 36);
            cBoxPesquisarPatente.TabIndex = 35;
            // 
            // txtNomeGuerraPesquisar
            // 
            txtNomeGuerraPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeGuerraPesquisar.Location = new Point(104, 14);
            txtNomeGuerraPesquisar.MaxLength = 50;
            txtNomeGuerraPesquisar.Name = "txtNomeGuerraPesquisar";
            txtNomeGuerraPesquisar.PlaceholderText = "Nome de Guerra";
            txtNomeGuerraPesquisar.Size = new Size(219, 34);
            txtNomeGuerraPesquisar.TabIndex = 34;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(209, 58, 58);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(478, 10);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(143, 36);
            btnLimpar.TabIndex = 37;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(209, 58, 58);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(627, 10);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(143, 36);
            btnExcluir.TabIndex = 38;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmExibir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(cBoxPesquisarPatente);
            Controls.Add(txtNomeGuerraPesquisar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmExibir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aptidão Militar Digital";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnPesquisar;
        private ComboBox cBoxPesquisarPatente;
        private TextBox txtNomeGuerraPesquisar;
        private Button btnLimpar;
        private Button btnExcluir;
    }
}