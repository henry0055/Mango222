using Microsoft.EntityFrameworkCore;
using Model;
using Model.Relaciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
   public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Persona> personas { get; set; }
        public DbSet<Media> medias { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Comentario> comentario { get; set; }
        public DbSet<Actor> actores { get; set; }


        public DbSet<MediaXActor> mediaxactor { get; set; }
        public DbSet<MediaXCategoria> mediaxcategoria { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
