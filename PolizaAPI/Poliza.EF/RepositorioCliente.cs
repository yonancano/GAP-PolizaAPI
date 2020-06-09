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
    public class RepositorioCliente : Repositorio<Model.Cliente>,IRepositorioCliente
    {

        public ContextoApp Contexto
        {
            get { return ContextoDB as ContextoApp; }
        }

        public RepositorioCliente(ContextoApp contexto) : base(contexto) { }

    }
}
