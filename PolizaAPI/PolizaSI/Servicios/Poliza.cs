using Poliza.BW;
using Poliza.BW.Administrar;
using Poliza.DA;
using Poliza.SI.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poliza.SI.Servicios
{
    public class Poliza : IPoliza
    {
        private readonly IDatosPoliza _datos;

        public Poliza(IDatosPoliza datos)
        {
            _datos = datos;
        }

        public bool AgreguePoliza(Model.Poliza poliza)
        {
            Administrador admin = new Administrador();
            return admin.Agregar(null);//_datos);
        }

        public bool EditePoliza(Model.Poliza poliza)
        {
            Administrador admin = new Administrador();
            return admin.Editar(null);//_datos);
        }

        public bool AsignePoliza(Model.Poliza poliza)
        {
            Administrador admin = new Administrador();
            return admin.Editar(null);//_datos);
        }
    }
}
