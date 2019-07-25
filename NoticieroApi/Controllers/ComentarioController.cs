using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoticieroApi.Models;
using NoticieroApi.Services;

namespace NoticieroApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Comentario")]
    public class ComentarioController : Controller
    {
        private readonly ComentarioService _ComentarioServicio;

        public ComentarioController(ComentarioService ComentarioServicio)
        {
            _ComentarioServicio = ComentarioServicio;
        }

        [Route("VerComentarios")]
        public IActionResult VerComentarios()
        {
            var resultado = _ComentarioServicio.VerComentario();
            return Ok(resultado);
        }

        [Route("Agregar")]
        [HttpPost]
        public IActionResult Agregar([FromBody] Comentario ComentarioAgregar)
        {
            if (_ComentarioServicio.Agregar(ComentarioAgregar))
            {
                return Ok("Agregado");
            }
            else
            {
                return BadRequest();
            }
        }

        [Route("Editar")]
        [HttpPut]
        public IActionResult Editar([FromBody] Comentario ComentarioEditar)
        {
            if (_ComentarioServicio.Editar(ComentarioEditar))
            {
                return Ok("Actualizado");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("Eliminar/{IdComentario}")]
        public IActionResult Eliminar(int IdComentario)
        {
            if (_ComentarioServicio.Eliminar(IdComentario))
            {
                return Ok("Borrado");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}