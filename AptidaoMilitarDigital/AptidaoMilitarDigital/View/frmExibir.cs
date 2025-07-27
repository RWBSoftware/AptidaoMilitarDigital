using AptidaoMilitarDigital.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptidaoMilitarDigital.View
{
    public partial class frmExibir : Form
    {
        public frmExibir()
        {
            InitializeComponent();
            NotaMilitarBD notaMilitarBD = new NotaMilitarBD();
            dataGridView1.DataSource = notaMilitarBD.BuscarTodosResultados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeGuerraPesquisar.Text))
            {
                MessageBox.Show("Por favor, insira um nome de guerra para pesquisar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NotaMilitarBD notaMilitarBD = new NotaMilitarBD();
            dataGridView1.DataSource = notaMilitarBD.BuscarMilitarEspecifico(txtNomeGuerraPesquisar.Text, cBoxPesquisarPatente.Text);



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeGuerraPesquisar.Clear();
            cBoxPesquisarPatente.SelectedIndex = -1;
            NotaMilitarBD notaMilitarBD = new NotaMilitarBD();
            dataGridView1.DataSource = notaMilitarBD.BuscarTodosResultados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                NotaMilitarBD notaMilitarBD = new NotaMilitarBD();
                notaMilitarBD.ExcluirDoBanco(id);
            }
        }
    }
}
