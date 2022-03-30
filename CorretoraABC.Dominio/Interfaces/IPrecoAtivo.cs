using CorretoraABC.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraABC.Dominio.Interfaces
{
    public interface IPrecoAtivo : IBase<PrecoAtivo>
    {
        Task<IList<PrecoAtivo>> ListarPrecoHistorico();
    }
}
