using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraABC.Dominio.Entidades
{
    public class PrecoAtivo
    {
        public string Date { get; set; }

        public decimal OpenPrice { get; set; }

        public decimal HighPrice { get; set; }

        public decimal LowPrice { get; set; }

        public decimal ClosePrice { get; set; }

        public decimal AdjClosePrice { get; set; }

        public decimal Volume { get; set; }
    }
}
