using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoticieroApi.Controllers;
using NoticieroApi.Models;
using NoticieroApi.Services;
using NoticieroApi.Persistance;
using System;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Mvc;

namespace NoticieroApiTest
{
    [TestClass]
    public class AutorTests
    {
        private readonly Autor Autor;
        private readonly Categoria Categoria;
        private readonly Comentario Comentario;
        private readonly Noticia Noticia;
        private readonly Usuario Usuario;

        NoticieroDbContext db= new NoticieroDbContext(new DbContextOptions<NoticieroDbContext>());

        //Pruebas a Autor-------------------------------------------------------------------------

        [TestMethod]
        public void NoestaVacio_Autor()
        {
            var Autor = new Autor();
            var result = Autor.ToString();
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void AddAutor()
        {
            var servicio = new AutorService(db);
            var controller = new AutorController(servicio);
            var result = controller.Agregar(Autor);
            Assert.IsNotNull(result);
            

        }

        [TestMethod]
        public void EditarAutor()
        {
            var servicio = new AutorService(db);
            var controller = new AutorController(servicio);
            var result = controller.Editar(Autor);
            Assert.IsNotNull(result);
        }

        //Pruebas a Categoria------------------------------------------------------------------

        [TestMethod]
        public void NoestaVacio_Categoria()
        {
            var Categoria = new Categoria();
            var result = Categoria.ToString();
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void AddCategoria()
        {
            var servicio = new CategoriaService(db);
            var controller = new CategoriaController(servicio);
            var result = controller.Agregar(Categoria);
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void EditarCategoria()
        {
            var servicio = new CategoriaService(db);
            var controller = new CategoriaController(servicio);
            var result = controller.Editar(Categoria);
            Assert.IsNotNull(result);

        }

        //Pruebas a Comentario-------------------------------------------------------------------

        [TestMethod]
        public void NoestaVacio_Comentario()
        {
            var Comentario = new Comentario();
            var result = Comentario.ToString();
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void AddComentario()
        {
            var servicio = new ComentarioService(db);
            var controller = new ComentarioController(servicio);
            var result = controller.Agregar(Comentario);
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void EditarComentario()
        {
            var servicio = new ComentarioService(db);
            var controller = new ComentarioController(servicio);
            var result = controller.Editar(Comentario);
            Assert.IsNotNull(result);

        }

        //Pruebas  a Noticia---------------------------------------------------------------------

        [TestMethod]
        public void NoestaVacio_Noticia()
        {
            var Noticia = new Noticia();
            var result = Noticia.ToString();
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void AddNoticia()
        {
            var servicio = new NoticiaService(db);
            var controller = new NoticiaController(servicio);
            var result = controller.Agregar(Noticia);
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void EditarNoticia()
        {
            var servicio = new NoticiaService(db);
            var controller = new NoticiaController(servicio);
            var result = controller.Editar(Noticia);
            Assert.IsNotNull(result);

        }

        //Pruebas  a Usuario----------------------------------------------------------------------

        [TestMethod]
        public void NoestaVacio_Usuario()
        {
            var Usuario = new Usuario();
            var result = Usuario.ToString();
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void AddUsuario()
        {
            var servicio = new UsuarioService(db);
            var controller = new UsuarioController(servicio);
            var result = controller.Agregar(Usuario);
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void EditarUsuario()
        {
            var servicio = new UsuarioService(db);
            var controller = new UsuarioController(servicio);
            var result = controller.Editar(Usuario);
            Assert.IsNotNull(result);

        }

    }
}
