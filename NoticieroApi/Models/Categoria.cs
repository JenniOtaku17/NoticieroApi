using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Models
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<Categoria> ebCategoria)
            {
                ebCategoria.HasKey(x => x.IdCategoria);
                ebCategoria.Property(x => x.nombre).HasColumnName("nombre").HasMaxLength(50);
                ebCategoria.Property(x => x.descripcion).HasColumnName("descripcion").HasMaxLength(500);
            }
        }
    }
}
