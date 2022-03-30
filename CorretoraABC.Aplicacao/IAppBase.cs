using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraABC.Aplicacao
{
    public interface IAppBase<T> where T : class
    {
        void Adicionar(T obj);
        T RecuperarPorId(Guid id);
        void Excluir(T obj);
        void Atualizar(T obj);
        IList<T> Listar();
    }
}
