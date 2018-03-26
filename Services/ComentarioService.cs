using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{



    public interface IComentarioService
    {
        List<Comentario> GetAll();
        bool Add(Comentario model);
        bool Update(Comentario model);
        bool Delete(int comentarioid);
        Comentario Get(int id);

    }


    public class ComentarioService : IComentarioService
    {
        private readonly ApplicationDbContext _DbContext;




        public ComentarioService(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public List<Comentario> GetAll()
        {
            var result = new List<Comentario>();
            try
            {

                result = _DbContext.comentario.ToList();

            }
            catch (Exception)
            {


            }
            return result;
        }

        public Comentario Get(int id) // obtener una persona por un id.
        {
            var result = new Comentario();
            try
            {

                result = _DbContext.comentario.Single(x => x.Id == id);

            }
            catch (Exception)
            {


            }
            return result;
        }
        public bool Add(Comentario model)
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
        public bool Update(Comentario model)
        {
            try
            {

                var originalModel = _DbContext.comentario.Single(x =>
                    x.Id == model.Id
                    );




                originalModel.contenido = model.contenido;
                




                _DbContext.Update(originalModel);
                _DbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Delete(int comentarioId)
        {
            try
            {
                _DbContext.Entry(new Comentario { Id = comentarioId }).State = EntityState.Deleted; ;
                _DbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }





    }

    
}
