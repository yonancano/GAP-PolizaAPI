using System;

namespace Poliza.BW.Administrar
{
    public class Administrador
    {
        public bool Agregar(DatosPoliza datos) 
        {
            if (datos.Validar())
            {
                return datos.Agregar();
            }
            else { 
                throw new Exception("Riesgo alto, el porcentaje de cobertura no puede ser superior al 50%");
            }
        }

        public bool Editar(DatosPoliza datos)
        {
            if (datos.Validar())
            {
                return datos.Editar();
            }
            else
            {
                throw new Exception("Riesgo alto, el porcentaje de cobertura no puede ser superior al 50%");
            }
        }

    }
}
