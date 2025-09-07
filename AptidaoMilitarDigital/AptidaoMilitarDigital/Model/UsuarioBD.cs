using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace AptidaoMilitarDigital.Model
{
    public class UsuarioBD
    {
        public SqliteDataReader dr;

        public string GetDatabasePath()
        {
#if DEBUG
            string dbPath = Path.Combine("C:\\Projetos\\AptidaoMilitarDigital\\AptidaoMilitarDigital\\Data", "AMD.db");
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
#else
    string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
    string appFolder = Path.Combine(folder, "AptidaoMilitarDigital", "Data");
    Directory.CreateDirectory(appFolder);

    string dbPath = Path.Combine(appFolder, "AMD.db");

    if (!File.Exists(dbPath))
    {
        string origem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "AMD.db");
        if (File.Exists(origem))
            File.Copy(origem, dbPath);
    }
#endif

            return dbPath;
        }



        public SqliteConnection GetConnection()
        {
            Batteries.Init();
            string con = $"Data Source={GetDatabasePath()};";
            return new SqliteConnection(con);
        }

        public DadosUsuario Login(string usuario, string senha)
        {
            DadosUsuario dadosUsuario = new DadosUsuario();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM AMD_Usuario WHERE Usuario = @usuario AND Senha = @senha;";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);
                    dr = command.ExecuteReader();
                    if (dr.HasRows && dr.Read())
                    {
                        dadosUsuario.Usuario = dr["Usuario"].ToString();
                        dadosUsuario.Senha = dr["Senha"].ToString();
                        dadosUsuario.NomeGuerra = dr["NomeGuerra"].ToString();
                        dadosUsuario.Patente = dr["Patente"].ToString();
                        return dadosUsuario;
                    }
                    else
                        return null;
                }
            }
        }

        public DadosUsuario Cadastro(string patente, string nomeGuerra, string usuario, string senha)
        {
            // Verifica se usuário existe antes de abrir conexão de insert
            if (Login(usuario, senha) != null)
            {
                MessageBox.Show("Usuário já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            using var connection = GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO AMD_Usuario (Patente, NomeGuerra, Usuario, Senha) VALUES (@patente, @nomeGuerra, @usuario, @senha)";
            command.Parameters.AddWithValue("@patente", patente);
            command.Parameters.AddWithValue("@nomeGuerra", nomeGuerra);
            command.Parameters.AddWithValue("@usuario", usuario);
            command.Parameters.AddWithValue("@senha", senha);

            int linhasAfetadas = command.ExecuteNonQuery();
            if (linhasAfetadas > 0)
            {
                return new DadosUsuario
                {
                    Patente = patente,
                    NomeGuerra = nomeGuerra,
                    Usuario = usuario,
                    Senha = senha
                };
            }
            else
                return null;
        }

        public void AlterarSenha(string usuario, string senhaAntiga, string senhaNova)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    DadosUsuario dadosUsuario = Login(usuario, senhaAntiga);
                        command.Parameters.Clear();
                        command.CommandText = "UPDATE AMD_Usuario SET Senha = @senhaNova WHERE Usuario = @usuario AND Senha = @senhaAntiga";
                        command.Parameters.AddWithValue("@senhaNova", senhaNova);
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@senhaAntiga", senhaAntiga);
                        int linhasAfetadas = command.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro ao alterar a senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
