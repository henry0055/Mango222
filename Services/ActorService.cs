using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{

    public interface IActorService
    {
        List<Actor> GetAll();
        bool Add(Actor model);
        bool Update(Actor model);
        bool Delete(int actorid);
        Actor Get(int id);
        List<Actor> GetRandom(int cantidad);

    }


    public class ActorService : IActorService
    {
        private readonly ApplicationDbContext _DbContext;




        public ActorService(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public List<Actor> GetAll()
        {
            var result = new List<Actor>();
            try
            {

                result = _DbContext.actores.ToList();

            }
            catch (Exception)
            {


            }
            return result;
        }

        public Actor Get(int id) // obtener una persona por un id.
        {
            var result = new Actor();
            try
            {

                result = _DbContext.actores.Single(x => x.Id == id);

            }
            catch (Exception)
            {


            }
            return result;
        }
        public bool Add(Actor model)
        {
            try
            {
                _DbContext.Add(model);
                _DbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Update(Actor model)
        {
            try
            {

                var originalModel = _DbContext.actores.Single(x =>
                    x.Id == model.Id
                    );


                  

                originalModel.Nombre = model.Nombre;
                originalModel.Apellido = model.Apellido;
                originalModel.Nacionalidad = model.Nacionalidad;
                originalModel.Descripcion = model.Descripcion;
                originalModel.Imagen = model.Imagen;
                originalModel.Edad = model.Edad;
        
             


                _DbContext.Update(originalModel);
                _DbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Delete(int actorId)
        {
            try
            {
                _DbContext.Entry(new Actor { Id = actorId }).State = EntityState.Deleted; ;
                _DbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public List<Actor> GetRandom(int cantidad)
        {
            var result = new List<Actor>();
            try
            {

                result = _DbContext.actores.OrderBy(r => Guid.NewGuid()).Take(cantidad).ToList();

            }
            catch (Exception)
            {


            }
            return result;
        }





    }




}