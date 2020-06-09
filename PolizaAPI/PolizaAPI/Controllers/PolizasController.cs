using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Poliza.Api.Controllers.Base;
using Poliza.BW;
using Poliza.EF;
using Poliza.Repositorio;

namespace PolizaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizasController : BaseController<Poliza.Model.Poliza, RepositorioPoliza>
    {
        private readonly IReglasPoliza _reglas;

        public PolizasController(RepositorioPoliza repositorio, IReglasPoliza reglas) : base(repositorio)
        {
            _reglas = reglas;
        }

        [HttpPost("/AgreguePoliza")]
        public void AgreguePoliza([FromBody] Poliza.Model.Poliza poliza)
        {
            try
            {
                if (_reglas.Validar(poliza))
                {
                    this.Repositorio.Agregue(poliza);
                }
            }
            catch (DbUpdateException ex)
            {
                throw new NotImplementedException("No se completo la acción Agregar.", ex);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("No se completo la acción Agregar." + ex.Message, ex);
            }
        }

        [HttpPut("/EditePoliza")]
        public bool EditePoliza([FromBody] Poliza.Model.Poliza poliza)
        {
            try
            {
                if (_reglas.Validar(poliza))
                {
                    this.Repositorio.Edite(poliza);
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new NotImplementedException("No se completo la acción Editar.", ex);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("No se completo la acción Editar." + ex.Message, ex);
            }

            return true;
        }

        ////Se hace el comentario de que es similar al AgreguePoliza/ 
        ////Pero mejor tener caminos independientes en diferentes acciones
        [HttpPost("/AsignePoliza")]
        public void AsignePoliza([FromBody] Poliza.Model.Poliza poliza)
        {
            try
            {
                if (_reglas.Validar(poliza))
                {
                    this.Repositorio.Agregue(poliza);
                }
            }
            catch (DbUpdateException)
            {
                throw new NotImplementedException("No se completo la acción Asignar.");
            }
        }

        ////Se hace el comentario de que es similar al EliminePoliza/ 
        ////Pero mejor tener caminos independientes en diferentes acciones
        [HttpPost("/CancelePoliza")]
        public bool CancelePoliza([FromBody] Poliza.Model.Poliza poliza)
        {
            try
            {
                this.Repositorio.Elimine(poliza);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new NotImplementedException("No se completo la acción Cancelar.");
            }

            return true;
        }

        [HttpGet("/ObtengaPolizasCliente")]
        public IEnumerable<Poliza.Model.Poliza> ObtenerPolizasCliente(int id)
        {
            return this.Repositorio.ObtengaPolizasPorCliente(id);
        }
    }
}
