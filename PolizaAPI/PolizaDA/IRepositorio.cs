using PolizaDA.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolizaDA
{
    public interface IRepositorio
    {
        IEnumerable<Poliza> ObtengaPolizas();

        Poliza ObtengaPolizaPorId(int id);

        bool AgreguePoliza(Poliza poliza);

        bool EditePoliza(Poliza poliza);

        bool EliminePoliza(int id);
    }
}
