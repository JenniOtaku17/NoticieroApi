using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using NoticieroApi.Models;

namespace NoticieroApiTest
{
    [TestClass]
    class UsuarioTests
    {
        [TestMethod]
        public void NoestaVacio()
        {
            var Usuario = new Usuario();
            var result = Usuario.ToString();
            Assert.IsNotNull(result);

        }
    }
}
