using Poliza.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poliza.DA
{
    public interface IRepositorio
    {
        IEnumerable<Model.Poliza> ObtengaPolizas();

        Model.Poliza ObtengaPolizaPorId(int id);

        bool AgreguePoliza(Model.Poliza poliza);

        bool EditePoliza(Model.Poliza poliza);

        bool EliminePoliza(int id);
    }
}
