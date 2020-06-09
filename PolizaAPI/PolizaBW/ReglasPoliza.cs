using System;
using System.Collections.Generic;
using System.Text;

namespace Poliza.BW
{
    public class ReglasPoliza : IReglasPoliza
    {

        //Regla de negocio
        public bool Validar(Model.Poliza poliza) 
        {
            if (poliza.TipoRiesgo == (byte)Model.Enumerados.TiposRiesgo.Alto)
            {
                if(poliza.PorcentajeCobertura <= 50)
                {
                    return true;
                }
                else
                {
                    NoCumpleRegla();
                }
            }

            return true;
        }
               

        private void NoCumpleRegla()
        {
            throw new Exception("Riesgo alto, el porcentaje de cobertura no puede ser superior al 50%");
        }
    }
}
