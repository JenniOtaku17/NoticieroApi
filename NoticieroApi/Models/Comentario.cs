using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
        public Usuario Usuario { get; set; }
        public Noticia Noticia { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<Comentario> ebComentario)
            {
                ebComentario.HasKey(x => x.IdComentario);
                ebComentario.Property(x => x.IdUsuario).HasColumnName("IdUsuario").HasColumnType("int");
                ebComentario.Property(x => x.IdNoticia).HasColumnName("IdNoticia").HasColumnType("int");
                ebComentario.Property(x => x.fecha).HasColumnName("fecha").HasColumnType("DateTime");
                ebComentario.Property(x => x.texto).HasColumnName("texto").HasMaxLength(500);
                ebComentario.HasOne(x => x.Usuario);
                ebComentario.HasOne(x => x.Noticia);
            }
        }
    }
}
