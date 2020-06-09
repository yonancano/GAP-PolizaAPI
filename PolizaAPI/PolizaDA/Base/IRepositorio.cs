using Poliza.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poliza.Repositorio.Base
{
    public interface IRepositorio<TModel> where TModel : class
    {
        IEnumerable<TModel> Obtenga();

        TModel ObtengaPorId(int id);

        void Agregue(TModel entity);

        void Edite(TModel entity);

        void Elimine(TModel entity);

    }
}
