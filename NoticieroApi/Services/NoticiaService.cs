using Microsoft.EntityFrameworkCore;
using NoticieroApi.Models;
using NoticieroApi.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Services
{
    public class NoticiaService
    {
        public readonly NoticieroDbContext _NoticiaDB;
        public NoticiaService(NoticieroDbContext NoticiaDB)
        {
            _NoticiaDB = NoticiaDB;
        }

        public List<Noticia> VerListadoTodasLasNoticias()
        {
            var NoticiaBuscada = _NoticiaDB.Noticia.Include(x => x.Autor).Include(x => x.Categoria).OrderByDescending(x => x.IdNoticia).ToList();
            return NoticiaBuscada;
        }

        public bool Agregar(Noticia NoticiaAgregar)
        {
            try
            {
                _NoticiaDB.Noticia.Add(NoticiaAgregar);
                _NoticiaDB.SaveChanges();
                return true;

            }
            catch (Exception error)
            {
                return false;

            }

        }

        public bool Editar(Noticia NoticiaEditar)
        {
            try
            {
                var noticia = _NoticiaDB.Noticia.FirstOrDefault(x => x.IdNoticia == NoticiaEditar.IdNoticia);
                noticia.titulo = NoticiaEditar.titulo;
                noticia.IdCategoria = NoticiaEditar.IdCategoria;
                noticia.IdAutor = NoticiaEditar.IdAutor;
                noticia.fecha = NoticiaEditar.fecha;
                noticia.contenido = NoticiaEditar.contenido;
                _NoticiaDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool Eliminar(int IdNoticia)
        {
            try
            {
                var NoticiaEliminar = _NoticiaDB.Noticia.FirstOrDefault(x => x.IdNoticia == IdNoticia);
                _NoticiaDB.Noticia.Remove(NoticiaEliminar);
                _NoticiaDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }

        }

    }
}
