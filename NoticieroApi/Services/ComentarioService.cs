using Microsoft.EntityFrameworkCore;
using NoticieroApi.Models;
using NoticieroApi.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Services
{
    public class ComentarioService
    {
        public readonly NoticieroDbContext _ComentarioDB;
        public ComentarioService(NoticieroDbContext ComentarioDB)
        {
            _ComentarioDB = ComentarioDB;
        }

        public List<Comentario> VerComentario()
        {
            var ComentarioBuscado = _ComentarioDB.Comentario.Include(x => x.Usuario).Include(x => x.Noticia).OrderByDescending(x => x.IdComentario).ToList();
            return ComentarioBuscado;
        }

        public bool Agregar(Comentario ComentarioAgregar)
        {
            try
            {
                _ComentarioDB.Comentario.Add(ComentarioAgregar);
                _ComentarioDB.SaveChanges();
                return true;

            }
            catch (Exception error)
            {
                return false;

            }

        }

        public bool Editar(Comentario ComentarioEditar)
        {
            try
            {
                var Comentario = _ComentarioDB.Comentario.FirstOrDefault(x => x.IdComentario == ComentarioEditar.IdComentario);
                Comentario.IdUsuario = ComentarioEditar.IdUsuario;
                Comentario.IdNoticia = ComentarioEditar.IdNoticia;
                Comentario.fecha = ComentarioEditar.fecha;
                Comentario.texto = ComentarioEditar.texto;
                _ComentarioDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool Eliminar(int IdComentario)
        {
            try
            {
                var ComentarioEliminar = _ComentarioDB.Comentario.FirstOrDefault(x => x.IdComentario == IdComentario);
                _ComentarioDB.Comentario.Remove(ComentarioEliminar);
                _ComentarioDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }

        }
    }
}
