using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Models
{
    public class Comentario
    {
        public int IdComentario { get; set; }
        public int IdUsuario { get; set; }
        public int IdNoticia { get; set; }
        public DateTime fecha { get; set; }
        public string texto { get; set; }
    }
}
