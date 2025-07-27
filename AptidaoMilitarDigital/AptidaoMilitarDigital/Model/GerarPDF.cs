using PdfSharp.Pdf;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.Data;
using MigraDoc.DocumentObjectModel.Tables;

namespace AptidaoMilitarDigital.Model
{
    public class GerarPDF
    {
        public void GerarPdfComTabela(DataTable tabela, string caminhoArquivo)
        {
            // Cria documento MigraDoc
            Document doc = new Document();
            doc.Info.Title = "Relatório Resultado Dos Militares";

            // Define estilo padrão
            Style style = doc.Styles["Normal"];
            style.Font.Name = "Segoe UI";
            style.Font.Size = 9; // Fonte menor para caber mais coisa

            // Cria seção com orientação paisagem
            Section secao = doc.AddSection();
            secao.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;

            // Cria uma tabela MigraDoc
            Table tabelaPdf = new Table();
            tabelaPdf.Borders.Width = 0.75;
            tabelaPdf.Format.Alignment = ParagraphAlignment.Center;

            int totalColunas = tabela.Columns.Count;
            double larguraTotal = 27.0; // Largura total de uma folha A4 paisagem em cm (com margem)
            double larguraColuna = larguraTotal / totalColunas;

            // Define colunas dinamicamente
            foreach (DataColumn coluna in tabela.Columns)
            {
                Column col = tabelaPdf.AddColumn(Unit.FromCentimeter(larguraColuna));
                col.Format.Alignment = ParagraphAlignment.Center;
            }

            // Cabeçalho
            Row cabecalho = tabelaPdf.AddRow();
            cabecalho.Shading.Color = Colors.LightGray;
            cabecalho.HeadingFormat = true;

            for (int i = 0; i < tabela.Columns.Count; i++)
            {
                cabecalho.Cells[i].AddParagraph(tabela.Columns[i].ColumnName);
                cabecalho.Cells[i].Format.Font.Bold = true;
                cabecalho.Cells[i].Format.Alignment = ParagraphAlignment.Center;
                cabecalho.Cells[i].Format.Font.Size = 9;
            }

            // Dados
            foreach (DataRow dr in tabela.Rows)
            {
                Row linha = tabelaPdf.AddRow();
                for (int i = 0; i < tabela.Columns.Count; i++)
                {
                    linha.Cells[i].AddParagraph(dr[i].ToString());
                    linha.Cells[i].Format.Alignment = ParagraphAlignment.Center;
                    linha.Cells[i].Format.Font.Size = 8;
                    linha.Cells[i].Format.LeftIndent = 0;
                }
            }

            // Adiciona a tabela
            secao.Add(tabelaPdf);

            // Renderiza
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true)
            {
                Document = doc
            };
            renderer.RenderDocument();

            // Salva
            renderer.PdfDocument.Save(caminhoArquivo);
        }
    }
}
