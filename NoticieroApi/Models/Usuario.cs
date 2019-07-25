using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string alias { get; set; }
        public string email { get; set; }
        public string contrasenia { get; set; }
    }
}
