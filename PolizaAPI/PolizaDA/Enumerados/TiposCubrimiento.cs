using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PolizaDA.Enumerados
{
    public enum TiposCubrimiento
    {
        [Description("Terremoto")]
        Terremoto = 1,
        [Description("Incendio")]
        Incendio = 2,
        [Description("Robo")]
        Robo = 3,
        [Description("Pérdida")]
        Perdida = 4
    }
}
