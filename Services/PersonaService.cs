using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface IPersonaService
    {
        List<Persona> GetAll();
        bool Add(Persona model);
        bool Update(Persona model);
        bool Delete(int id);
        Persona Get(int id);
        
        Persona Login(Persona persona);
    }

    public class PersonaService : IPersonaService
    {
        private readonly ApplicationDbContext _DbContext;

    


        public PersonaService( ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public List<Persona> GetAll()
        {
            var result = new List<Persona>();
            try
            {

                result = _DbContext.personas.ToList();

            }
            catch (Exception)
            {


            }
            return result;
        }

        public Persona Get(int id) // obtener una persona por un id.
        {
            var result = new Persona();
            try
            {

                result = _DbContext.personas.Single(x => x.Id == id);

            }
            catch (Exception)
            {


            }
            return result;
        }
        public bool Add(Persona model)
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
        public bool Update(Persona model)
        {
            try
            {

                var originalModel = _DbContext.personas.Single(x =>
                    x.Id == model.Id
                    );

                originalModel.username = model.username;
                originalModel.password = model.password;
                originalModel.nombre = model.nombre;
                originalModel.apellidos = model.apellidos;
                originalModel.correo = model.correo;
                originalModel.foto = model.foto;
                originalModel.nacimiento = model.nacimiento;

                originalModel.username = model.username;

                _DbContext.Update(originalModel);
                _DbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Delete(int id)
        {
            try
            {
                var persona = _DbContext.personas
                    .Where(a => a.Id == id).FirstOrDefault();

               // _DbContext.Entry(persona).State = EntityState.Deleted;
                _DbContext.personas.Remove(persona);
                _DbContext.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }





        public Persona Login(Persona persona ) // validacion
        {
            var result = new Persona();
            
            try
            {

                result = _DbContext.personas.FirstOrDefault(x => x.username.Equals(persona.username)  && x.password.Equals(persona.password) );

            }
            catch (Exception)
            {
                

            }
            return result;
        }

    }
}
