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
    public partial class frmConfig : Form
    {
        DadosUsuario dadosUsuario = new DadosUsuario();
        public frmConfig(DadosUsuario _dadosUsuario)
        {
            InitializeComponent();
            dadosUsuario = _dadosUsuario;
        }

        private void btnTrocarConta_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(dadosUsuario);
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            frmAvaliacao frmAvaliacao = new frmAvaliacao(dadosUsuario);
            frmAvaliacao.Show();
            this.Close();
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frmAlterarSenha = new frmAlterarSenha(dadosUsuario);
            frmAlterarSenha.Show();
            this.Close();
        }
    }
}
