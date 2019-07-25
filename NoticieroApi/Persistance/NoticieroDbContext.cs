using Microsoft.EntityFrameworkCore;
using NoticieroApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Persistance
{
    public class NoticieroDbContext: DbContext
    {
        public NoticieroDbContext(DbContextOptions opciones): base(opciones)
        {

        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Comentario> Comentario { get; set; }
        public virtual DbSet<Noticia> Noticia { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelB)
        {
            new Autor.Map(modelB.Entity<Autor>());
            new Categoria.Map(modelB.Entity<Categoria>());
            new Comentario.Map(modelB.Entity<Comentario>());
            new Noticia.Map(modelB.Entity<Noticia>());
            new Usuario.Map(modelB.Entity<Usuario>());
            base.OnModelCreating(modelB);
        }

    }

}
