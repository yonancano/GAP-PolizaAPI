using Microsoft.EntityFrameworkCore;
using PolizaDA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PolizaDA
{
    public class Repositorio : IRepositorio
    {
        private readonly Contexto _contexto;

        public Repositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Poliza> ObtengaPolizas()
        {
            return _contexto.Polizas.ToList();
        }

        public Poliza ObtengaPolizaPorId(int id)
        {
            return _contexto.Polizas.Find(id);
        }

        public bool AgreguePoliza(Poliza poliza)
        {
            _contexto.Polizas.Add(poliza);

            var cambios = _contexto.SaveChanges();
            return cambios > 0;
        }

        public bool EditePoliza(Poliza poliza)
        {
            _contexto.Polizas.Update(poliza);
            _contexto.Entry(poliza).State = EntityState.Modified;

            var cambios = _contexto.SaveChanges();
            return cambios > 0;
        }

        public bool EliminePoliza(int id)
        {
            var poliza = _contexto.Polizas.Find(id);
             _contexto.Polizas.Remove(poliza);

            var cambios = _contexto.SaveChanges();
            return cambios > 0;
        }

    }
}
