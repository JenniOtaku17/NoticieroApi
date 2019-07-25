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
    [Route("api/Noticia")]
    public class NoticiaController : Controller
    {
        private readonly NoticiaService _NoticiaServicio;

        public NoticiaController(NoticiaService NoticiaServicio)
        {
            _NoticiaServicio = NoticiaServicio;
        }


        public IActionResult Prueba()
        {
            return Ok("Funciona");

        }

        [Route("VerNoticias")]
        public IActionResult VerNoticias()
        {
            var resultado = _NoticiaServicio.VerNoticia();
            return Ok(resultado);
        }

        [Route("Agregar")]
        [HttpPost]
        public IActionResult Agregar([FromBody] Noticia NoticiaAgregar)
        {
            if (_NoticiaServicio.Agregar(NoticiaAgregar))
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
        public IActionResult Editar([FromBody] Noticia NoticiaEditar)
        {
            if (_NoticiaServicio.Editar(NoticiaEditar))
            {
                return Ok("Actualizado");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("Eliminar/{IdNoticia}")]
        public IActionResult Eliminar(int IdNoticia)
        {
            if (_NoticiaServicio.Eliminar(IdNoticia))
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