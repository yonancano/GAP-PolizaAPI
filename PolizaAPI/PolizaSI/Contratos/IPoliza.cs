using PolizaDA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolizaSI.Contratos
{
    public interface IPoliza
    {
        IEnumerable<Poliza> ObtengaPolizas();
        Poliza ObtengaPolizaPorId(int id);
        bool AgrueguePoliza(Poliza poliza);
        bool EditePoliza(Poliza poliza);
        bool EliminePoliza(int id);
    }
}
