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
    [Route("api/Usuario")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _UsuarioServicio;

        public UsuarioController(UsuarioService UsuarioServicio)
        {
            _UsuarioServicio = UsuarioServicio;
        }

        [Route("VerUsuarios")]
        public IActionResult VerUsuarios()
        {
            var resultado = _UsuarioServicio.VerUsuario();
            return Ok(resultado);
        }

        [Route("Agregar")]
        [HttpPost]
        public IActionResult Agregar([FromBody] Usuario UsuarioAgregar)
        {
            if (_UsuarioServicio.Agregar(UsuarioAgregar))
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
        public IActionResult Editar([FromBody] Usuario UsuarioEditar)
        {
            if (_UsuarioServicio.Editar(UsuarioEditar))
            {
                return Ok("Actualizado");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("Eliminar/{IdUsuario}")]
        public IActionResult Eliminar(int IdUsuario)
        {
            if (_UsuarioServicio.Eliminar(IdUsuario))
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