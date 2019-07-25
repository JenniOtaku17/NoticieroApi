using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Models
{
    public class Autor
    {
        public int IdAutor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<Autor> ebAutor)
            {
                ebAutor.HasKey(x => x.IdAutor);
                ebAutor.Property(x => x.nombre).HasColumnName("nombre").HasMaxLength(50);
                ebAutor.Property(x => x.apellido).HasColumnName("apellido").HasMaxLength(50);
            }
        }
    }
}
