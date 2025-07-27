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
            style.Font.Size = 14;

            // Cria uma seção no documento
            Section secao = doc.AddSection();

            // Cria uma tabela MigraDoc
            Table tabelaPdf = new Table();
            tabelaPdf.Borders.Width = 0.75;

            // Define colunas baseado nas colunas do DataTable
            foreach (DataColumn coluna in tabela.Columns)
            {
                Column col = tabelaPdf.AddColumn(Unit.FromCentimeter(3)); // largura fixa 3 cm, pode ajustar
                col.Format.Alignment = ParagraphAlignment.Center;
            }

            // Linha de cabeçalho
            Row linhaCabecalho = tabelaPdf.AddRow();
            linhaCabecalho.Shading.Color = Colors.LightGray;
            linhaCabecalho.HeadingFormat = true;

            for (int i = 0; i < tabela.Columns.Count; i++)
            {
                linhaCabecalho.Cells[i].AddParagraph(tabela.Columns[i].ColumnName);
                linhaCabecalho.Cells[i].Format.Font.Bold = true;
                linhaCabecalho.Cells[i].Format.Alignment = ParagraphAlignment.Center;
            }

            // Preenche dados
            foreach (DataRow dr in tabela.Rows)
            {
                Row linha = tabelaPdf.AddRow();
                for (int i = 0; i < tabela.Columns.Count; i++)
                {
                    linha.Cells[i].AddParagraph(dr[i].ToString());
                    linha.Cells[i].Format.Alignment = ParagraphAlignment.Center;
                }
            }

            // Adiciona a tabela na seção
            secao.Add(tabelaPdf);

            // Renderiza PDF
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true)
            {
                Document = doc
            };
            renderer.RenderDocument();

            // Salva o arquivo
            renderer.PdfDocument.Save(caminhoArquivo);
        }
    }
}
