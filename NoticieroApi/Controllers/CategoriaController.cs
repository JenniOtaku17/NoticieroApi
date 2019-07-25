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
    [Route("api/Categoria")]
    public class CategoriaController : Controller
    {
        private readonly CategoriaService _CategoriaServicio;

        public CategoriaController(CategoriaService CategoriaServicio)
        {
            _CategoriaServicio = CategoriaServicio;
        }

        [Route("VerCategorias")]
        public IActionResult VerCategorias()
        {
            var resultado = _CategoriaServicio.VerCategoria();
            return Ok(resultado);
        }

        [Route("Agregar")]
        [HttpPost]
        public IActionResult Agregar([FromBody] Categoria CategoriaAgregar)
        {
            if (_CategoriaServicio.Agregar(CategoriaAgregar))
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
        public IActionResult Editar([FromBody] Categoria CategoriaEditar)
        {
            if (_CategoriaServicio.Editar(CategoriaEditar))
            {
                return Ok("Actualizado");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("Eliminar/{IdCategoria}")]
        public IActionResult Eliminar(int IdCategoria)
        {
            if (_CategoriaServicio.Eliminar(IdCategoria))
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