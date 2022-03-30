using CorretoraABC.Dados.Converter;
using CorretoraABC.Dominio.Entidades;
using CorretoraABC.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;

namespace CorretoraABC.Dados.Repositorio
{
    public class PrecoAtivoRepositorio : RepositorioBase<PrecoAtivo>, IPrecoAtivo
    {
        public async Task<IList<PrecoAtivo>> ListarPrecoHistorico()
        {
            var result = await Yahoo.GetHistoricalAsync("petr4.sa", new DateTime(2021, 03, 21), new DateTime(2022, 03, 28), Period.Daily);
            var convert = result.Where(a => a.Close != 0)
                                           .OrderByDescending(a => a.DateTime)
                                           .ToList()
                                           .ConvertAll(a => PrecoAtivoConverter.ItemToFileHelperDto(a));
            return convert;
        }
    }
}
