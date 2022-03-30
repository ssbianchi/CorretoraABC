using CorretoraABC.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;

namespace CorretoraABC.Dados.Converter
{
    public class PrecoAtivoConverter
    {
        public static PrecoAtivo ItemToFileHelperDto(Candle item)
        {
            return new PrecoAtivo()
            {
                Date = item.DateTime.ToString("MM/dd/yyyy"),
                OpenPrice = item.Open,
                HighPrice = item.High,
                LowPrice = item.Low,
                ClosePrice = item.Close,
                AdjClosePrice = item.AdjustedClose,
                Volume = item.Volume,
            };
        }
    }
}
