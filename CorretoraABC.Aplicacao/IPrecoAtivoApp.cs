using CorretoraABC.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraABC.Aplicacao
{
    public interface IPrecoAtivoApp: IAppBase<PrecoAtivo>
    {
        Task<IList<PrecoAtivo>> ListarPrecoHistorico();
    }
}
