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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            VerificarHorario();
        }


        public void VerificarHorario()
        {
            DateTime horaAtual = DateTime.Now;
            label2.Text = horaAtual.ToString("dd/MM/yy HH:mm:ss");

            int hora = horaAtual.Hour;
            if (hora >= 6 && hora < 12)
                label1.Text = "Bom dia!";
            else if (hora >= 12 && hora < 18)
                label1.Text = "Boa tarde!";
            else
                label1.Text = "Boa noite!\nSd Silva Santos";
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
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
            if (int.TryParse(txtBoxIdade.Text, out int idade))
            {
                if (idade < 18 || idade > 80)
                {
                    MessageBox.Show("A idade deve estar entre 18 e 80 anos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Digite uma idade válida (número inteiro).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cBoxSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o sexo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cBoxCarreira.SelectedIndex == -1)
            {
                MessageBox.Show("Informe se é militar de carreira", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrEmpty(txtBoxCorrida.Text))
            {
                MessageBox.Show("Informe a distância da corrida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFlexao.Text))
            {
                MessageBox.Show("Informe o número de flexões.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBoxAbd.Text))
            {
                MessageBox.Show("Informe o número de abdominais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBoxBarra.Text))
            {
                MessageBox.Show("Informe o número de barras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txtBoxCorrida.Text, out int corrida))
            {
                if (corrida < 0 || corrida > 5000)
                {
                    MessageBox.Show("A corrida deve ser um valor entre 0 e 5000 metros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            if (int.TryParse(txtBoxFlexao.Text, out int Flexao))
            {
                if (Flexao < 0 || Flexao > 200)
                {
                    MessageBox.Show("A flexão deve ser um valor entre 0 e 200.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (int.TryParse(txtBoxAbd.Text, out int Abd))
            {
                if (Abd < 0 || Abd > 200)
                {
                    MessageBox.Show("O número de abdominais deve ser um valor entre 0 e 200.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (int.TryParse(txtBoxBarra.Text, out int Barra))
            {
                if (Barra < 0 || Barra > 100)
                {
                    MessageBox.Show("O número de barras deve ser um valor entre 0 e 100.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrEmpty(txtBoxNotaCorrida.Text))
            {
                MessageBox.Show("Informe a nota da corrida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBoxNotaFlexao.Text))
            {
                MessageBox.Show("Informe a nota da flexão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBoxNotaAbd.Text))
            {
                MessageBox.Show("Informe a nota da abdominal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBoxNotaBarra.Text))
            {
                MessageBox.Show("Informe a nota da barra.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }

        private void txtBoxIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela a tecla pressionada
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNomeGuerra.Clear();
            cBoxPatente.SelectedIndex = -1;
            txtBoxIdade.Clear();
            cBoxSexo.SelectedValue = -1;
            cBoxCarreira.SelectedValue = -1;
            txtBoxCorrida.Clear();
            txtBoxFlexao.Clear();
            txtBoxAbd.Clear();
            txtBoxBarra.Clear();
            txtBoxNotaCorrida.Clear();
            txtBoxNotaFlexao.Clear();
            txtBoxNotaAbd.Clear();
            txtBoxNotaBarra.Clear();
        }

        private void cBoxSexo_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                this.BeginInvoke(new Action(() =>
                {
                    for (int i = 0; i < cBoxSexo.Items.Count; i++)
                    {
                        if (i != e.Index)
                        {
                            cBoxSexo.SetItemChecked(i, false);
                        }
                    }
                }));
            }
        }

        private void cBoxCarreira_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                this.BeginInvoke(new Action(() =>
                {
                    for (int i = 0; i < cBoxCarreira.Items.Count; i++)
                    {
                        if (i != e.Index)
                        {
                            cBoxCarreira.SetItemChecked(i, false);
                        }
                    }
                }));
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
