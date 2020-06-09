using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poliza.Repositorio.Base;

namespace Poliza.Api.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TModel, TRepositorio> : ControllerBase where TModel : class where TRepositorio : IRepositorio<TModel>
    {
        protected readonly TRepositorio Repositorio;

        public BaseController(TRepositorio repositorio)
        {
            this.Repositorio = repositorio;
        }

        [HttpGet("/Obtener")]
        public IEnumerable<TModel> Obtener()
        {
            return Repositorio.Obtenga();
        }

        [HttpGet("/ObtenerPorId")]
        public TModel ObtenerPorId(int id)
        {
            return Repositorio.ObtengaPorId(id);
        }

        [HttpPost("/Agregar")]
        public void Agregar([FromBody] TModel item)
        {
            Repositorio.Agregue(item);
        }

        [HttpPut("/Editar")]
        public void Editar([FromBody] TModel item)
        {
            Repositorio.Edite(item);
        }

        [HttpPost("/Eliminar")]
        public void Eliminar([FromBody] TModel item)
        {
            Repositorio.Elimine(item);
        }
    }
}
