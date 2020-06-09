using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Poliza.DA
{
    public class Repositorio : IRepositorio
    {
        private readonly Contexto _contexto;

        public Repositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Model.Poliza> ObtengaPolizas()
        {
            return _contexto.Polizas.ToList();
        }

        public Model.Poliza ObtengaPolizaPorId(int id)
        {
            return _contexto.Polizas.Find(id);
        }

        public bool AgreguePoliza(Model.Poliza poliza)
        {
            _contexto.Polizas.Add(poliza);

            var cambios = _contexto.SaveChanges();
            return cambios > 0;
        }

        public bool EditePoliza(Model.Poliza poliza)
        {
            _contexto.Polizas.Update(poliza);
            _contexto.Entry(poliza).State = EntityState.Modified;

            var cambios = _contexto.SaveChanges();
            return cambios > 0;
        }

        public bool EliminePoliza(int id)
        {
            var poliza = _contexto.Polizas.Find(id);

            if (poliza != null)
            {
                _contexto.Polizas.Remove(poliza);
            }

            var cambios = _contexto.SaveChanges();
            return cambios > 0;
        }

    }
}
