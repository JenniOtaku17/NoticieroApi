using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using NoticieroApi.Models;

namespace NoticieroApiTest
{
    [TestClass]
    class NoticiaTests
    {
        [TestMethod]
        public void NoestaVacio()
        {
            var Noticia = new Noticia();
            var result = Noticia.ToString();
            Assert.IsNotNull(result);

        }
    }
}
