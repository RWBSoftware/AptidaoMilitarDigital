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
    public partial class frmMenuPrincipal : Form
    {
        public int IDMilitar = 0;
        public DadosUsuario dadosUsuario;
        public frmMenuPrincipal(DadosUsuario _dadosUsuario)
        {
            InitializeComponent();
            VerificarHorario();
            dadosUsuario = _dadosUsuario;
        }


        public void VerificarHorario()
        {
            DateTime horaAtual = DateTime.Now;
            label2.Text = horaAtual.ToString("dd/MM/yy HH:mm");

            int hora = horaAtual.Hour;
            if (hora >= 6 && hora < 12)
                label1.Text = "Bom dia!";
            else if (hora >= 12 && hora < 18)
                label1.Text = "Boa tarde!";
            else
                label1.Text = "Boa noite!";
        }

        public void VerificarCadastroNota()
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
            if (string.IsNullOrEmpty(txtBoxCorrida.Text))
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

            NotaMilitarBD notaMilitarBD = new NotaMilitarBD();
            bool booleanoCarreira = false;
            switch (cBoxCarreira.SelectedItem.ToString())
            {
                case "Sim":
                    booleanoCarreira = true;
                    break;
                case "Não":
                    booleanoCarreira = false;
                    break;
            }


            ResultadoDosMilitares resultado = new ResultadoDosMilitares
            {
                NomeGuerra = txtBoxNomeGuerra.Text,
                Idade = Convert.ToInt32(txtBoxIdade.Text),
                Patente = cBoxPatente.SelectedItem.ToString(),
                Sexo = cBoxSexo.SelectedItem.ToString(),
                Carreira = booleanoCarreira,
                Corrida = Convert.ToInt32(txtBoxCorrida.Text),
                Flexao = Convert.ToInt32(txtBoxFlexao.Text),
                Barra = Convert.ToInt32(txtBoxBarra.Text),
                Abdominal = Convert.ToInt32(txtBoxAbd.Text),
                NotaCorrida = txtBoxNotaCorrida.Text,
                NotaFlexao = txtBoxNotaFlexao.Text,
                NotaBarra = txtBoxNotaBarra.Text,
                NotaAbd = txtBoxNotaAbd.Text
            };

            if (IDMilitar == 0)
            {
                if (notaMilitarBD.InserirResultado(resultado))
                {
                    MessageBox.Show("Resultado cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpar.PerformClick();
                }
                else { MessageBox.Show("Erro ao cadastrar o resultado. Verifique os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                resultado.Id = IDMilitar;
                if (notaMilitarBD.AtualizarResultado(resultado))
                {
                    MessageBox.Show("Resultado atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpar.PerformClick();
                    IDMilitar = 0;
                }
                else { MessageBox.Show("Erro ao atualizar o resultado. Verifique os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            VerificarCadastroNota();
        }

        private void txtBoxIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeGuerraPesquisar.Clear();
            cBoxPesquisarPatente.SelectedIndex = -1;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cBoxPesquisarPatente.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma patente para pesquisar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNomeGuerraPesquisar.Text))
            {
                MessageBox.Show("Por favor, insira um nome de guerra para pesquisar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            NotaMilitarBD notaMilitarBD = new NotaMilitarBD();
            ResultadoDosMilitares resultadoDosMilitares = new ResultadoDosMilitares();
            resultadoDosMilitares = notaMilitarBD.BuscarPorNomeGuerraEPatente(txtNomeGuerraPesquisar.Text, cBoxPesquisarPatente.Text);
            if (resultadoDosMilitares == null)
            {
                MessageBox.Show("Nenhum resultado encontrado para o nome de guerra e patente informados.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IDMilitar = resultadoDosMilitares.Id;
                txtBoxNomeGuerra.Text = resultadoDosMilitares.NomeGuerra;
                cBoxPatente.SelectedItem = resultadoDosMilitares.Patente;
                txtBoxIdade.Text = resultadoDosMilitares.Idade.ToString();
                cBoxSexo.SelectedItem = resultadoDosMilitares.Sexo;
                cBoxCarreira.SelectedItem = resultadoDosMilitares.Carreira;
                txtBoxCorrida.Text = resultadoDosMilitares.Corrida.ToString();
                txtBoxFlexao.Text = resultadoDosMilitares.Flexao.ToString();
                txtBoxAbd.Text = resultadoDosMilitares.Abdominal.ToString();
                txtBoxBarra.Text = resultadoDosMilitares.Barra.ToString();
                txtBoxNotaCorrida.Text = resultadoDosMilitares.NotaCorrida.ToString();
                txtBoxNotaFlexao.Text = resultadoDosMilitares.NotaFlexao.ToString();
                txtBoxNotaAbd.Text = resultadoDosMilitares.NotaAbd.ToString();
                txtBoxNotaBarra.Text = resultadoDosMilitares.NotaBarra.ToString();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            frmExibir frm = new frmExibir();
            frm.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            NotaMilitarBD notaMilitarBD = new NotaMilitarBD();
            GerarPDF gerarPDF = new GerarPDF();
            DataTable dados = notaMilitarBD.BuscarTodosResultados();
            string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminho = Path.Combine(pastaDocumentos, "RelatorioMilitar.pdf");
            gerarPDF.GerarPdfComTabela(dados, caminho);
            MessageBox.Show("PDF gerado com sucesso!");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig(dadosUsuario);
            frmConfig.Show();
            this.Close();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            VerificarHorario();
        }
    }
}
