using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PolizaAPI.Enumerados
{
    public enum TiposRiesgo
    {
        [Description("bajo")]
        Bajo = 1,
        [Description("medio")]
        Medio = 2,
        [Description("medio-alto")]
        MedioAlto = 3,
        [Description("alto")]
        Alto = 4
    }
}
