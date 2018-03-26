﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Persistence;
using System;

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180305005118_agregandoClaveForanea_Publicacion")]
    partial class agregandoClaveForanea_Publicacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("apellidos");

                    b.Property<string>("correo");

                    b.Property<string>("foto");

                    b.Property<DateTime>("nacimiento");

                    b.Property<string>("nombre");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("Id");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("Model.Publicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PersonaId");

                    b.Property<string>("contenido");

                    b.Property<DateTime>("fecha");

                    b.Property<string>("foto");

                    b.HasKey("Id");

                    b.ToTable("publicaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
