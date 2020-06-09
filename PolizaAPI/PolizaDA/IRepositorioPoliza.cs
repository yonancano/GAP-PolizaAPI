using Poliza.Repositorio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poliza.Repositorio
{
    public interface IRepositorioPoliza : IRepositorio<Model.Poliza>
    {
        void AsignePoliza(Model.Poliza poliza);

        void CancelePoliza(Model.Poliza poliza);

        IEnumerable<Model.Poliza> ObtengaPolizasPorCliente(int idCliente);
    }
}
