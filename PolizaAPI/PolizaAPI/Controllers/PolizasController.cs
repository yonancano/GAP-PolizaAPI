using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Poliza.BW;
using Poliza.DA;

namespace PolizaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizasController : ControllerBase
    {
        private readonly IReglasPoliza _reglas;
        private readonly IRepositorio _repositorio;

        public PolizasController(IRepositorio repositorio, IReglasPoliza reglas)
        {
            _repositorio = repositorio;
            _reglas = reglas;
        }

        [HttpGet("/ObtengaPolizas")]
        public IEnumerable<Poliza.Model.Poliza> ObtengaPolizas()
        {
            return _repositorio.ObtengaPolizas();
        }

        [HttpGet("/ObtengaPoliza")]
        public Poliza.Model.Poliza ObtengaPolizaPorId(int id)
        {
            var poliza = _repositorio.ObtengaPolizaPorId(id);

            if (poliza == null)
            {
                return null;
            }

            return poliza;
        }

        [HttpPost("/AgreguePoliza")]
        public void AgreguePoliza([FromBody]Poliza.Model.Poliza poliza)
        {
            try
            {
                if (_reglas.Validar(poliza))
                {
                    _repositorio.AgreguePoliza(poliza);
                }
            }
            catch (DbUpdateException ex)
            {
                throw new NotImplementedException("No se completo la acción Agregar.", ex);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("No se completo la acción Agregar."+ ex.Message, ex);
            }
        }

        [HttpPut("/EditePoliza")]
        public bool EditePoliza([FromBody] Poliza.Model.Poliza poliza)
        {
            try
            {
                if (_reglas.Validar(poliza))
                {
                    _repositorio.EditePoliza(poliza);
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

        [HttpDelete("/EliminePoliza")]
        public bool EliminePoliza(int id)
        {
            try
            {
                _repositorio.EliminePoliza(id);
            }
            catch (DbUpdateException ex)
            {
                throw new NotImplementedException("No se completo la acción Eliminar.", ex);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("No se completo la acción Eliminar." + ex.Message, ex);
            }

            return true;
        }

        //Se hace el comentario de que es similar al AgreguePoliza/ 
        //Pero mejor tener caminos independientes en diferentes acciones
        [HttpPost("/AsignePoliza")]
        public void AsignePoliza([FromBody] Poliza.Model.Poliza poliza)
        {
            try
            {
                if (_reglas.Validar(poliza))
                {
                    _repositorio.EditePoliza(poliza);
                }
            }
            catch (DbUpdateException)
            {
                throw new NotImplementedException("No se completo la acción Asignar.");
            }
        }

        //Se hace el comentario de que es similar al EliminePoliza/ 
        //Pero mejor tener caminos independientes en diferentes acciones
        [HttpPut("/CancelePoliza")]
        public bool CancelePoliza(int id)
        {
            try
            {
                _repositorio.EliminePoliza(id);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new NotImplementedException("No se completo la acción Cancelar.");
            }

            return true;
        }
    }
}
