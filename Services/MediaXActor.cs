using Microsoft.EntityFrameworkCore;
using Model.Relaciones;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{

    public interface IMediaXActorService
    {
        List<MediaXActor> GetAll();
        bool Add(MediaXActor model);
        bool Update(MediaXActor model);
        bool Delete(int mediaxactorid);
        MediaXActor Get(int id);
        

    }


    public class MediaXActorService : IMediaXActorService
    {
        private readonly ApplicationDbContext _DbContext;




        public MediaXActorService(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public List<MediaXActor> GetAll()
        {
            var result = new List<MediaXActor>();
            try
            {

                result = _DbContext.mediaxactor.ToList();

            }
            catch (Exception)
            {


            }
            return result;
        }

        public MediaXActor Get(int id) // obtener una persona por un id.
        {
            var result = new MediaXActor();
            try
            {

                result = _DbContext.mediaxactor.Single(x => x.Id == id);

            }
            catch (Exception)
            {


            }
            return result;
        }
        public bool Add(MediaXActor model)
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
        public bool Update(MediaXActor model)
        {
            try
            {

                var originalModel = _DbContext.mediaxactor.Single(x =>
                    x.Id == model.Id
                    );




                originalModel.IdActor = model.IdActor;
                originalModel.IdMedia = model.IdMedia;
              
                _DbContext.Update(originalModel);
                _DbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Delete(int mediaxactorId)
        {
            try
            {
                _DbContext.Entry(new MediaXActor { Id = mediaxactorId }).State = EntityState.Deleted; ;
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
