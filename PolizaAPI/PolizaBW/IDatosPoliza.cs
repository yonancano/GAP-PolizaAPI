using Poliza.DA;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poliza.BW
{
    public interface IDatosPoliza
    {
        IRepositorio _repositorio { get; set; }
        Poliza.Model.Poliza Poliza { get; set; }
        
    }
}
