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
    public class RepositorioBase<T> : IBase<T>, IDisposable where T : class
    {
        //private readonly DbContextOptions<EstacaoRecargaDbContext> _optionsBuilder;

        public RepositorioBase()
        {
            //_optionsBuilder = new DbContextOptions<EstacaoRecargaDbContext>();
        }

        public void Adicionar(T obj)
        {
            //using (var db = new EstacaoRecargaDbContext(_optionsBuilder))
            //{
            //    try
            //    {
            //        db.Set<T>().Add(obj);
            //        db.SaveChanges();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }

            //}
            throw new NotImplementedException();
        }

        public T RecuperarPorId(Guid id)
        {
            //using (var db = new EstacaoRecargaDbContext(_optionsBuilder))
            //{
            //    return db.Set<T>().Find(id);
            //}
            throw new NotImplementedException();
        }

        public void Atualizar(T obj)
        {
            //using (var db = new EstacaoRecargaDbContext(_optionsBuilder))
            //{
            //    db.Set<T>().Update(obj);
            //    db.SaveChanges();
            //}
            throw new NotImplementedException();
        }

        public void Excluir(T obj)
        {
            //using (var db = new EstacaoRecargaDbContext(_optionsBuilder))
            //{
            //    db.Set<T>().Remove(obj);
            //    db.SaveChanges();
            //}
            throw new NotImplementedException();
        }

        public IList<T> Listar()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
