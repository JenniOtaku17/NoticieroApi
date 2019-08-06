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
    class CategoriaTests
    {
        private readonly Categoria Categoria;

        NoticieroDbContext db = new NoticieroDbContext(new DbContextOptions<NoticieroDbContext>());

        [TestMethod]
        public void NoestaVacio()
        {
            var Categoria = new Categoria();
            var result = Categoria.ToString();
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void Add()
        {
            var servicio = new CategoriaService(db);
            var controller = new CategoriaController(servicio);
            var result = controller.Agregar(Categoria);
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void Editar()
        {
            var servicio = new CategoriaService(db);
            var controller = new CategoriaController(servicio);
            var result = controller.Editar(Categoria);
            Assert.IsNotNull(result);

        }

    }
}
