using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptidaoMilitarDigital.Model
{
    public class NotaMilitarBD
    {
        public SqlConnection conexao = new SqlConnection(@"Data Source=LAPTOPZEMBER; Initial Catalog=AptidãoMilitarDigital; Integrated Security=True;TrustServerCertificate=True;");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;

        public bool InserirResultado(ResultadoDosMilitares resultado)
        {
            if(VerificarSeExisteOMilitarNoBD(resultado.NomeGuerra, resultado.Patente))
            {
                MessageBox.Show("Já existe um resultado cadastrado para este militar.");
                return false;
            }

            try
            {
                conexao.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = @"INSERT INTO ResultadoDosMilitares 
        (NomeGuerra, Idade, Patente, Sexo, Carreira, Corrida, Flexao, Barra, Abdominal, NotaCorrida, NotaFlexao, NotaBarra, NotaAbd) 
        VALUES 
        (@NomeGuerra, @Idade, @Patente, @Sexo, @Carreira, @Corrida, @Flexao, @Barra, @Abdominal, @NotaCorrida, @NotaFlexao, @NotaBarra, @NotaAbd)";

                cmd.Parameters.AddWithValue("@NomeGuerra", resultado.NomeGuerra);
                cmd.Parameters.AddWithValue("@Idade", resultado.Idade);
                cmd.Parameters.AddWithValue("@Patente", resultado.Patente);
                cmd.Parameters.AddWithValue("@Sexo", resultado.Sexo);
                cmd.Parameters.AddWithValue("@Carreira", resultado.Carreira);
                cmd.Parameters.AddWithValue("@Corrida", resultado.Corrida);
                cmd.Parameters.AddWithValue("@Flexao", resultado.Flexao);
                cmd.Parameters.AddWithValue("@Barra", resultado.Barra);
                cmd.Parameters.AddWithValue("@Abdominal", resultado.Abdominal);
                cmd.Parameters.AddWithValue("@NotaCorrida", resultado.NotaCorrida);
                cmd.Parameters.AddWithValue("@NotaFlexao", resultado.NotaFlexao);
                cmd.Parameters.AddWithValue("@NotaBarra", resultado.NotaBarra);
                cmd.Parameters.AddWithValue("@NotaAbd", resultado.NotaAbd);

                cmd.Connection = conexao;

                int linhasAfetadas = cmd.ExecuteNonQuery();
                return linhasAfetadas > 0;
            }
            catch (Exception erro) { MessageBox.Show("Erro ao inserir resultado: " + erro.Message); return false; }
            finally { conexao.Close(); }
        }

        public bool VerificarSeExisteOMilitarNoBD(string nomeGuerra, string patente)
        {
            try
            {
                conexao.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = @"SELECT * FROM ResultadoDosMilitares WHERE NomeGuerra = @nomeGuerra AND Patente = @patente";
                cmd.Parameters.AddWithValue("@nomeGuerra", nomeGuerra);
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Connection = conexao;

                dr = cmd.ExecuteReader();

                return dr.HasRows;
            }
            catch (Exception ex) { MessageBox.Show("Erro ao buscar resultado: " + ex.Message); return false; }
            finally { conexao.Close(); }
        }


        public ResultadoDosMilitares BuscarPorNomeGuerraEPatente(string nomeGuerra, string patente)
        {
            try
            {
                conexao.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = @"SELECT * FROM ResultadoDosMilitares WHERE NomeGuerra = @nomeGuerra AND Patente = @patente";
                cmd.Parameters.AddWithValue("@nomeGuerra", nomeGuerra);
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Connection = conexao;

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    ResultadoDosMilitares resultado = new ResultadoDosMilitares
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        NomeGuerra = dr["NomeGuerra"].ToString(),
                        Idade = Convert.ToInt32(dr["Idade"]),
                        Patente = dr["Patente"].ToString(),
                        Sexo = dr["Sexo"].ToString(),
                        Carreira = Convert.ToBoolean(dr["Carreira"]),
                        Corrida = Convert.ToInt32(dr["Corrida"]),
                        Flexao = Convert.ToInt32(dr["Flexao"]),
                        Barra = Convert.ToInt32(dr["Barra"]),
                        Abdominal = Convert.ToInt32(dr["Abdominal"]),
                        NotaCorrida = dr["NotaCorrida"].ToString(),
                        NotaFlexao = dr["NotaFlexao"].ToString(),
                        NotaBarra = dr["NotaBarra"].ToString(),
                        NotaAbd = dr["NotaAbd"].ToString()
                    };

                    return resultado;
                }
                else
                {
                    return null; // não achou ninguém com esse nome + patente
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao buscar resultado: " + ex.Message); return null; }
            finally { conexao.Close(); }
        }

        public bool AtualizarResultado(ResultadoDosMilitares resultado)
        {
            try
            {
                conexao.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = @"UPDATE ResultadoDosMilitares SET 
            NomeGuerra = @NomeGuerra,
            Idade = @Idade,
            Patente = @Patente,
            Sexo = @Sexo,
            Carreira = @Carreira,
            Corrida = @Corrida,
            Flexao = @Flexao,
            Barra = @Barra,
            Abdominal = @Abdominal,
            NotaCorrida = @NotaCorrida,
            NotaFlexao = @NotaFlexao,
            NotaBarra = @NotaBarra,
            NotaAbd = @NotaAbd
        WHERE Id = @Id";

                cmd.Parameters.AddWithValue("@Id", resultado.Id);
                cmd.Parameters.AddWithValue("@NomeGuerra", resultado.NomeGuerra);
                cmd.Parameters.AddWithValue("@Idade", resultado.Idade);
                cmd.Parameters.AddWithValue("@Patente", resultado.Patente);
                cmd.Parameters.AddWithValue("@Sexo", resultado.Sexo);
                cmd.Parameters.AddWithValue("@Carreira", resultado.Carreira);
                cmd.Parameters.AddWithValue("@Corrida", resultado.Corrida);
                cmd.Parameters.AddWithValue("@Flexao", resultado.Flexao);
                cmd.Parameters.AddWithValue("@Barra", resultado.Barra);
                cmd.Parameters.AddWithValue("@Abdominal", resultado.Abdominal);
                cmd.Parameters.AddWithValue("@NotaCorrida", resultado.NotaCorrida);
                cmd.Parameters.AddWithValue("@NotaFlexao", resultado.NotaFlexao);
                cmd.Parameters.AddWithValue("@NotaBarra", resultado.NotaBarra);
                cmd.Parameters.AddWithValue("@NotaAbd", resultado.NotaAbd);

                cmd.Connection = conexao;

                int linhasAfetadas = cmd.ExecuteNonQuery();
                return linhasAfetadas > 0;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar resultado: " + erro.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable BuscarTodosResultados()
        {
            DataTable tabela = new DataTable();

            try
            {
                conexao.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM ResultadoDosMilitares";
                cmd.Connection = conexao;

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception ex) { MessageBox.Show("Erro ao buscar dados: " + ex.Message); return null; }
            finally{ conexao.Close(); }
        }

        public DataTable BuscarMilitarEspecifico(string nomeGuerra, string patente)
        {
            DataTable tabela = new DataTable();

            try
            {
                conexao.Open();
                cmd.Parameters.Clear();

                cmd.CommandText = @"SELECT * FROM ResultadoDosMilitares WHERE NomeGuerra LIKE @NomeGuerra AND (@Patente IS NULL OR Patente = @Patente)";

                cmd.Parameters.AddWithValue("@NomeGuerra", $"%{nomeGuerra}%");
                cmd.Parameters.AddWithValue("@Patente", string.IsNullOrEmpty(patente) ? (object)DBNull.Value : patente);
                cmd.Connection = conexao;

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception ex) { MessageBox.Show("Erro ao buscar dados: " + ex.Message); return null; }
            finally{ conexao.Close(); }
        }

        public void ExcluirDoBanco(int id)
        {
            try
            {
                conexao.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM ResultadoDosMilitares WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = conexao;

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
                else
                    MessageBox.Show("Nenhum registro encontrado.");
            }
            catch (Exception ex) { MessageBox.Show("Erro ao excluir: " + ex.Message); }
            finally { conexao.Close(); }
        }


    }
}
