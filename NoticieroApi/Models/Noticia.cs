using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Models
{
    public class Noticia
    {
        public int IdNoticia { get; set; }
        public string titulo { get; set; }
        public int IdCategoria { get; set; }
        public int IdAutor { get; set; }
        public DateTime fecha { get; set; }
        public string contenido { get; set; }
    }
}
