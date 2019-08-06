using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using NoticieroApi.Models;

namespace NoticieroApiTest
{
    [TestClass]
    class ComentarioTests
    {
        [TestMethod]
        public void NoestaVacio()
        {
            var Comentario = new Comentario();
            var result = Comentario.ToString();
            Assert.IsNotNull(result);

        }
    }
}
