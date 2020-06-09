using Poliza.DA;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poliza.BW
{
    public class DatosPoliza : IDatosPoliza
    {
        public IRepositorio _repositorio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Model.Poliza Poliza { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //Regla de negocio
        public bool Validar() 
        {
            if (Poliza.TipoRiesgo == (byte) Model.Enumerados.TiposRiesgo.Alto) 
            {
                return Poliza.TipoRiesgo <= 50;
            }

            return true;
        }

        public bool Agregar() 
        {
            return _repositorio.AgreguePoliza(Poliza);
        }

        public bool Editar()
        {
            return _repositorio.EditePoliza(Poliza);
        }
    }
}
