using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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

        public class Map
        {
            public Map(EntityTypeBuilder<Usuario> ebUsuario)
            {
                ebUsuario.HasKey(x => x.IdUsuario);
                ebUsuario.Property(x => x.alias).HasColumnName("alias").HasMaxLength(30);
                ebUsuario.Property(x => x.email).HasColumnName("email").HasMaxLength(100);
                ebUsuario.Property(x => x.contrasenia).HasColumnName("contrasenia").HasMaxLength(50);
            }
        }
    }
}
