using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptidaoMilitarDigital.Model
{
    public class NotaMilitarBD : UsuarioBD
    {
        public SqlConnection conexao = new SqlConnection(@"Data Source=LAPTOPZEMBER; Initial Catalog=AptidãoMilitarDigital; Integrated Security=True;TrustServerCertificate=True;");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;

        public bool InserirResultado(ResultadoDosMilitares resultado)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    if (VerificarSeExisteOMilitarNoBD(resultado.NomeGuerra, resultado.Patente))
                    {
                        MessageBox.Show("Já existe um resultado cadastrado para este militar.");
                        return false;
                    }

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

                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
            }   
        }

        public bool VerificarSeExisteOMilitarNoBD(string nomeGuerra, string patente)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = @"SELECT * FROM ResultadoDosMilitares WHERE NomeGuerra = @nomeGuerra AND Patente = @patente";
                    cmd.Parameters.AddWithValue("@nomeGuerra", nomeGuerra);
                    cmd.Parameters.AddWithValue("@patente", patente);

                    using var dr = cmd.ExecuteReader();

                    return dr.HasRows;
                }
            }
        }


        public ResultadoDosMilitares BuscarPorNomeGuerraEPatente(string nomeGuerra, string patente)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = @"SELECT * FROM ResultadoDosMilitares WHERE NomeGuerra = @nomeGuerra AND Patente = @patente";
                    cmd.Parameters.AddWithValue("@nomeGuerra", nomeGuerra);
                    cmd.Parameters.AddWithValue("@patente", patente);

                    using var dr = cmd.ExecuteReader();

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
                        return null;
                }
            }
        }

        public bool AtualizarResultado(ResultadoDosMilitares resultado)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
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

                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
            }
        }

        public DataTable BuscarTodosResultados()
        {
            DataTable tabela = new DataTable();

            using var connection = GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM ResultadoDosMilitares";

            using var reader = command.ExecuteReader();

            tabela.Load(reader); // Carrega direto o DataReader no DataTable

            return tabela;
        }

        public DataTable BuscarMilitarEspecifico(string nomeGuerra, string patente)
        {
            DataTable tabela = new DataTable();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = @"SELECT * FROM ResultadoDosMilitares WHERE NomeGuerra LIKE @NomeGuerra AND (@Patente IS NULL OR Patente = @Patente)";
                    cmd.Parameters.AddWithValue("@NomeGuerra", $"%{nomeGuerra}%");
                    cmd.Parameters.AddWithValue("@Patente", string.IsNullOrEmpty(patente) ? (object)DBNull.Value : patente);

                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.Fill(tabela);

                    return tabela;
                }
            }
        }

        public void ExcluirDoBanco(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "DELETE FROM ResultadoDosMilitares WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                        MessageBox.Show("Registro excluído com sucesso!");
                    else
                        MessageBox.Show("Nenhum registro encontrado.");
                }
            }
        }
    }
}
