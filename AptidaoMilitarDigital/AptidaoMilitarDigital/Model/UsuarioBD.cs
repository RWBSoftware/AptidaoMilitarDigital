using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AptidaoMilitarDigital.Model
{
    public class UsuarioBD
    {
        public SqlConnection conexao = new SqlConnection(@"Data Source=LAPTOPZEMBER; Initial Catalog=AptidãoMilitarDigital; Integrated Security=True;TrustServerCertificate=True;");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;

        public bool Login(string usuario, string senha)
        {
            try
            {
                conexao.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM AMD_Usuario WHERE Usuario = @usuario AND Senha = @senha";
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Connection = conexao;
                dr = cmd.ExecuteReader();
                return dr.HasRows;
            }
            catch (Exception erro) { MessageBox.Show(erro.Message); return false; }
            finally { conexao.Close(); }
        }

        public bool Cadastro(string patente, string nomeGuerra, string usuario, string senha)
        {
            if (Login(usuario, senha))
                return false;

            try
            {
                conexao.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO AMD_Usuario (Patente, NomeGuerra, Usuario, Senha) VALUES (@patente, @nomeGuerra, @usuario, @senha)";
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Parameters.AddWithValue("@nomeGuerra", nomeGuerra);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Connection = conexao;
                int linhasAfetadas = cmd.ExecuteNonQuery();
                if (linhasAfetadas > 0)
                    return true;
                else
                    return false;;
            }
            catch (Exception erro) { MessageBox.Show(erro.Message); return false; }
            finally { conexao.Close(); }
        }
    }
}
