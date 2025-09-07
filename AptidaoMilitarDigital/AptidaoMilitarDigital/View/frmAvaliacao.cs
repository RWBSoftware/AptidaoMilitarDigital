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
    public partial class frmAvaliacao : Form
    {
        DadosUsuario dadosUsuario = new DadosUsuario();
        public frmAvaliacao(DadosUsuario _dadosUsuario)
        {
            InitializeComponent();
            dadosUsuario = _dadosUsuario;
        }

        public void Verificacao()
        {
            if (int.TryParse(txtNota.Text, out int nota))
            {
                if (nota >= 0 && nota <= 5)
                {
                    MessageBox.Show("Nota registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AbrirForms();
                }
                else
                    MessageBox.Show("Por favor, insira uma nota válida entre 0 e 5.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Por favor, insira uma nota válida entre 0 e 5.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void AbrirForms()
        {
            frmConfig frmConfig = new frmConfig(dadosUsuario);
            frmConfig.Show();
            this.Close();
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Verificacao();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AbrirForms();
        }
    }
}
