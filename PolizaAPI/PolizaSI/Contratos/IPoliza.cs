using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poliza.SI.Contratos
{
    public interface IPoliza
    {
        bool AgreguePoliza(Model.Poliza poliza);
        bool EditePoliza(Model.Poliza poliza);
        bool AsignePoliza(Model.Poliza poliza);
    }
}
