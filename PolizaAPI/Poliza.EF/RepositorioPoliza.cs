using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Poliza.EF.Abstracta;
using Poliza.Repositorio;
using Poliza.EF.Contexto;

namespace Poliza.EF
{
    public class RepositorioPoliza : Repositorio<Model.Poliza>,IRepositorioPoliza
    {

        public ContextoApp Contexto
        {
            get { return ContextoDB as ContextoApp; }
        }

        public RepositorioPoliza(ContextoApp contexto) : base(contexto) { }

        public void AsignePoliza(Model.Poliza poliza)
        {
            Contexto.Polizas.Add(poliza);
        }

        public void CancelePoliza(Model.Poliza poliza)
        {
            Contexto.Polizas.Remove(poliza);
        }

        public IEnumerable<Model.Poliza> ObtengaPolizasPorCliente(int idCliente)
        {
            return Contexto.Polizas.Where(x => x.IdCliente == idCliente);
        }
    }
}
