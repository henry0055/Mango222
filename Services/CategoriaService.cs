using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface ICategoriaService
    {
        List<Categoria> GetAll();
        bool Add(Categoria model);
        bool Update(Categoria model);
        bool Delete(int categoriaId);
        Categoria Get(int id);
    }

     public class CategoriaService : ICategoriaService
        {
            private readonly ApplicationDbContext _DbContext;




            public CategoriaService(ApplicationDbContext dbContext)
            {
                _DbContext = dbContext;
            }

            public List<Categoria> GetAll()
            {
                var result = new List<Categoria>();
                try
                {

                    result = _DbContext.categorias.ToList();

                }
                catch (Exception)
                {


                }
                return result;
            }

            public Categoria Get(int id) // obtener una persona por un id.
            {
                var result = new Categoria();
                try
                {

                    result = _DbContext.categorias.Single(x => x.Id == id);

                }
                catch (Exception)
                {


                }
                return result;
            }
            public bool Add(Categoria model)
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
            public bool Update(Categoria model)
            {
                try
                {

                    var originalModel = _DbContext.categorias.Single(x =>
                        x.Id == model.Id
                        );



                    originalModel.NombreCategoria = model.NombreCategoria;



                    _DbContext.Update(originalModel);
                    _DbContext.SaveChanges();

                }
                catch (Exception)
                {

                    return false;
                }
                return true;
            }
            public bool Delete(int categoriaId)
            {
                try
                {
                    _DbContext.Entry(new Media { Id = categoriaId }).State = EntityState.Deleted; ;
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
