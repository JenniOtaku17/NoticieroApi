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
    [Route("api/Autor")]
    public class AutorController : Controller
    {
        private readonly AutorService _AutorServicio;

        public AutorController(AutorService AutorServicio)
        {
            _AutorServicio = AutorServicio;
        }

        [Route("VerAutores")]
        public IActionResult VerAutores()
        {
            var resultado = _AutorServicio.VerAutor();
            return Ok(resultado);
        }

        [Route("Agregar")]
        [HttpPost]
        public IActionResult Agregar([FromBody] Autor AutorAgregar)
        {
            if (_AutorServicio.Agregar(AutorAgregar))
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
        public IActionResult Editar([FromBody] Autor AutorEditar)
        {
            if (_AutorServicio.Editar(AutorEditar))
            {
                return Ok("Actualizado");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("Eliminar/{IdAutor}")]
        public IActionResult Eliminar(int IdAutor)
        {
            if (_AutorServicio.Eliminar(IdAutor))
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