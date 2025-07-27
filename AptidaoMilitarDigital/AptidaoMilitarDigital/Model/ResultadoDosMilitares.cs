using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptidaoMilitarDigital.Model
{
    public class ResultadoDosMilitares
    {
        public int Id { get; set; } = 0;
        public string NomeGuerra { get; set; }
        public int Idade { get; set; }
        public string Patente { get; set; }
        public string Sexo { get; set; }
        public bool Carreira { get; set; }
        public int Corrida { get; set; }
        public int Flexao { get; set; }
        public int Barra { get; set; }
        public int Abdominal { get; set; }
        public string NotaCorrida { get; set; }
        public string NotaFlexao { get; set; }
        public string NotaBarra { get; set; }
        public string NotaAbd { get; set; }
    }
}
