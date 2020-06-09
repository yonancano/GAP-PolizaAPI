using System;
using System.Collections.Generic;
using System.Text;

namespace Poliza.BW
{
    public interface IReglasPoliza
    {
        public bool Validar(Model.Poliza poliza);
    }
}
