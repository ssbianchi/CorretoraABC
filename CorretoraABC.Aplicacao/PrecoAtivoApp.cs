using CorretoraABC.Dominio.Entidades;
using CorretoraABC.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraABC.Aplicacao
{
    public class PrecoAtivoApp : IPrecoAtivoApp
    {
        IPrecoAtivo _precoAtivoRepoInterface;
        public PrecoAtivoApp(IPrecoAtivo precoAtivoRepoInterface)
        {
            _precoAtivoRepoInterface = precoAtivoRepoInterface;
        }
        public void Adicionar(PrecoAtivo obj)
        {
            _precoAtivoRepoInterface.Adicionar(obj);
        }

        public void Atualizar(PrecoAtivo obj)
        {
            _precoAtivoRepoInterface.Atualizar(obj);
        }

        public void Excluir(PrecoAtivo obj)
        {
            _precoAtivoRepoInterface.Excluir(obj);
        }

        public IList<PrecoAtivo> Listar()
        {
            return _precoAtivoRepoInterface.Listar();
        }

        public async Task<IList<PrecoAtivo>> ListarPrecoHistorico()
        {
            return await _precoAtivoRepoInterface.ListarPrecoHistorico();
        }

        public PrecoAtivo RecuperarPorId(Guid id)
        {
            return _precoAtivoRepoInterface.RecuperarPorId(id);
        }
    }
}
