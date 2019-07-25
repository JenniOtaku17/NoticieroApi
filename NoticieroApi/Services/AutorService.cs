using Microsoft.EntityFrameworkCore;
using NoticieroApi.Models;
using NoticieroApi.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Services
{
    public class AutorService
    {
        public readonly NoticieroDbContext _AutorDB;
        public AutorService(NoticieroDbContext AutorDB)
        {
            _AutorDB = AutorDB;
        }

        public List<Autor> VerAutor()
        {
            var AutorBuscado = _AutorDB.Autor.OrderByDescending(x => x.IdAutor).ToList();
            return AutorBuscado;
        }

        public bool Agregar(Autor AutorAgregar)
        {
            try
            {
                _AutorDB.Autor.Add(AutorAgregar);
                _AutorDB.SaveChanges();
                return true;

            }
            catch (Exception error)
            {
                return false;

            }

        }

        public bool Editar(Autor AutorEditar)
        {
            try
            {
                var Autor = _AutorDB.Autor.FirstOrDefault(x => x.IdAutor ==AutorEditar.IdAutor);
                Autor.nombre = AutorEditar.nombre;
                Autor.apellido = AutorEditar.apellido;
                _AutorDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool Eliminar(int IdAutor)
        {
            try
            {
                var AutorEliminar = _AutorDB.Autor.FirstOrDefault(x => x.IdAutor == IdAutor);
                _AutorDB.Autor.Remove(AutorEliminar);
                _AutorDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }

        }

     
    }
}
