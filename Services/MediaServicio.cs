﻿using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface IMediaService
    {
        List<Media> GetAll();
        bool Add(Media model);
        bool Update(Media model);
        bool Delete(int mediaid);
        Media Get(int id);
        Media primero();
        List<Media> GetRandom(int cantidad);
        bool Calificar(int id, int acumulado);
    }
    

        public class MediaService : IMediaService
        {
            private readonly ApplicationDbContext _DbContext;




            public MediaService(ApplicationDbContext dbContext)
            {
                _DbContext = dbContext;
            }

            public List<Media> GetAll()
            {
                var result = new List<Media>();
                try
                {

                    result = _DbContext.medias.ToList();

                }
                catch (Exception)
                {


                }
                return result;
            }

            public Media Get(int id) // obtener una persona por un id.
            {
                var result = new Media();
                try
                {

                    result = _DbContext.medias.Single(x => x.Id == id);

                }
                catch (Exception)
                {


                }
                return result;
            }
            public bool Add(Media model)
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
            public bool Update(Media model)
            {
                try
                {

                    var originalModel = _DbContext.medias.Single(x =>
                        x.Id == model.Id
                        );

       

                    originalModel.Tipo = model.Tipo;
                    originalModel.Nombre = model.Nombre;
                    originalModel.Duracion = model.Duracion;
                    originalModel.Temporadas = model.Temporadas;
                    originalModel.Estado = model.Estado;
                    originalModel.Imagen = model.Imagen;
                    originalModel.Estreno = model.Estreno;
                    originalModel.Contador = model.Contador;
                    originalModel.Acumulado = model.Acumulado;

                   
                    _DbContext.Update(originalModel);
                    _DbContext.SaveChanges();

                }
                catch (Exception)
                {

                    return false;
                }
                return true;
            }
            public bool Delete(int mediaid)
            {
                try
                {
                    _DbContext.Entry(new Media { Id = mediaid }).State = EntityState.Deleted; ;
                    _DbContext.SaveChanges();

                }
                catch (Exception)
                {

                    return false;
                }
                return true;
            }


            public Media primero()
            {
                var result = new Media();
                try
                {
                    result = _DbContext.medias.FirstOrDefault();
                }
                catch (Exception)
                {


                }
                return result;
            }

        public List<Media>GetRandom(int cantidad) 
        {
            var result = new List<Media>();
            try
            {

                result = _DbContext.medias.OrderBy(r => Guid.NewGuid()).Take(cantidad).ToList();

            }
            catch (Exception)
            {


            }
            return result;
        }


        public bool Calificar(int id , int acumulado)
        {
            try
            {

                var originalModel = _DbContext.medias.Single(x =>
                    x.Id == id
                    );


                originalModel.Contador = originalModel.Contador + 1 ;
                originalModel.Acumulado = originalModel.Acumulado + acumulado ;


                _DbContext.Update(originalModel);
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


