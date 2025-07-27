using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptidaoMilitarDigital.Model
{
    public class HashSenha
    {
        public string GerarHash(string senha)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public bool VerificarSenha(string senha, string hash)
        {
            string hashGerado = GerarHash(senha);
            return hashGerado.Equals(hash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
