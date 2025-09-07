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
    public partial class frmAlterarSenha : Form
    {
        DadosUsuario dadosUsuario = new DadosUsuario();
        public frmAlterarSenha(DadosUsuario _dadosUsuario)
        {
            InitializeComponent();
            Limpar();
            dadosUsuario = _dadosUsuario;
        }
        public void Limpar()
        {
            txtSenhaAtual.Focus();
            txtSenhaAtual.Clear();
            txtSenhaNova.Clear();
            txtSenhaNovaNovamente.Clear();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenhaAtual.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtSenhaNova.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtSenhaNovaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig(dadosUsuario);
            frmConfig.Show();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            VerificarSenhas();
        }

        public void VerificarSenhas()
        {
            HashSenha hashSenha = new HashSenha();
            if(hashSenha.GerarHash(txtSenhaAtual.Text) != dadosUsuario.Senha)
            {
                MessageBox.Show("Senha atual incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSenhaNova.Text != txtSenhaNovaNovamente.Text)
            {
                MessageBox.Show("As senhas novas não coincidem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSenhaNova.Text.Length < 6)
            {
                MessageBox.Show("A nova senha deve ter no mínimo 6 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UsuarioBD usuarioBD = new UsuarioBD();
            usuarioBD.AlterarSenha(dadosUsuario.Usuario, hashSenha.GerarHash(txtSenhaAtual.Text), hashSenha.GerarHash(txtSenhaNova.Text));
            dadosUsuario.Senha = hashSenha.GerarHash(txtSenhaNova.Text);
            Limpar();
        }
    }
}
