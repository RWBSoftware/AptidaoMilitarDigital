using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AptidaoMilitarDigital.View
{
    public partial class frmLogin : Form
    {
        private RememberMeManager rememberMeManager = new RememberMeManager();

        public frmLogin()
        {
            InitializeComponent();
            LembrarDeMimAtivo();
        }

        public void LembrarDeMimAtivo()
        {
            var data = rememberMeManager.Load();

            if (data != null && data.RememberMe)
            {
                txtBoxUsuario.Text = data.Username;
                txtBoxSenha.Text = data.Password;
                cBoxLembrarMim.Checked = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void cBoxLembrarMim_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLembrarMim.Checked)
                rememberMeManager.Save(new RememberMeData { Username = txtBoxUsuario.Text, Password = txtBoxSenha.Text, RememberMe = cBoxLembrarMim.Checked });
            else
                rememberMeManager.Clear();
        }
    }
}
