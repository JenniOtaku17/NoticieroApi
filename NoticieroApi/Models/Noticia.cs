using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
        public Categoria Categoria { get; set; }
        public Autor Autor { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<Noticia> ebNoticia)
            {
                ebNoticia.HasKey(x => x.IdNoticia);
                ebNoticia.Property(x => x.titulo).HasColumnName("titulo").HasMaxLength(50);
                ebNoticia.Property(x => x.IdCategoria).HasColumnName("IdCategoria").HasColumnType("int");
                ebNoticia.Property(x => x.IdAutor).HasColumnName("IdAutor").HasColumnType("int");
                ebNoticia.Property(x => x.fecha).HasColumnName("fecha").HasColumnType("DateTime");
                ebNoticia.Property(x => x.contenido).HasColumnName("contenido").HasMaxLength(2000);
                ebNoticia.HasOne(x => x.Categoria);
                ebNoticia.HasOne(x => x.Autor);
            }
        }
    }
}
