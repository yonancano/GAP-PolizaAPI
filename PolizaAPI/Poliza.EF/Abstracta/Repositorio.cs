using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Poliza.Repositorio.Base;

namespace Poliza.EF.Abstracta
{
    public abstract class Repositorio<TModel> : IRepositorio<TModel> where TModel : class
    {
        protected readonly DbContext ContextoDB;

        public Repositorio(DbContext contexto)
        {
            ContextoDB = contexto;
        }

        public void Agregue(TModel entity)
        {
            ContextoDB.Set<TModel>().Add(entity);
            ContextoDB.SaveChanges();
        }

        public void Edite(TModel entity)
        {
            ContextoDB.Set<TModel>().Update(entity);
            ContextoDB.SaveChanges();
        }

        public void Elimine(TModel entity)
        {
            ContextoDB.Set<TModel>().Remove(entity);
            ContextoDB.SaveChanges();
        }

        public IEnumerable<TModel> Obtenga()
        {
            return ContextoDB.Set<TModel>().ToList();
        }

        public TModel ObtengaPorId(int id)
        {
            return ContextoDB.Set<TModel>().Find(id);
        }
    }
}
