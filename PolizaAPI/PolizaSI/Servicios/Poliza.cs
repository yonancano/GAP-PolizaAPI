using PolizaDA;
using PolizaSI.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolizaSI.Servicios
{
    public class Poliza : IPoliza
    {
        private readonly IRepositorio _repositorio;

        public Poliza(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<PolizaDA.Modelos.Poliza> ObtengaPolizas()
        {
            return _repositorio.ObtengaPolizas();
        }

        public PolizaDA.Modelos.Poliza ObtengaPolizaPorId(int id)
        {
            return _repositorio.ObtengaPolizaPorId(id);
        }

        public bool AgreguePoliza(PolizaDA.Modelos.Poliza poliza)
        {
            poliza.InicioVigencia = DateTime.Now;
            return _repositorio.AgreguePoliza(poliza);
        }

        public bool EditePoliza(PolizaDA.Modelos.Poliza poliza)
        {
            return _repositorio.EditePoliza(poliza);
        }

        public bool EliminePoliza(int id)
        {
            return _repositorio.EliminePoliza(id);
        }

    }
}
