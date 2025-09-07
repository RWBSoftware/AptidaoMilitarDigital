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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text.Length < 4)
            {
                MessageBox.Show("O nome de usuário deve ter pelo menos 4 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBoxNomeGuerra.Text.Length < 4)
            {
                MessageBox.Show("O nome de guerra deve ter pelo menos 4 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cBoxPatente.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma patente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBoxSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsuarioBD usuarioBD = new UsuarioBD();
            HashSenha hashSenha = new HashSenha();
            DadosUsuario dadosUsuario = usuarioBD.Cadastro(cBoxPatente.SelectedItem.ToString(), txtBoxNomeGuerra.Text, txtBoxUsuario.Text, hashSenha.GerarHash(txtBoxSenha.Text));
            if (dadosUsuario != null)
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(dadosUsuario);
                frmMenuPrincipal.Show();
                this.Close();
            }
            else { MessageBox.Show("Erro ao realizar o cadastro. Verifique os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
