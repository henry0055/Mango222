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
    [Migration("20180320233627_foraneaslistas")]
    partial class foraneaslistas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Edad");

                    b.Property<string>("Imagen");

                    b.Property<string>("Nacionalidad");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("actores");
                });

            modelBuilder.Entity("Model.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreCategoria");

                    b.HasKey("Id");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("Model.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdMedia");

                    b.Property<int>("IdPersona");

                    b.Property<string>("contenido");

                    b.Property<DateTime>("fecha");

                    b.Property<int?>("mediaId");

                    b.Property<int?>("personaId");

                    b.HasKey("Id");

                    b.HasIndex("mediaId");

                    b.HasIndex("personaId");

                    b.ToTable("comentario");
                });

            modelBuilder.Entity("Model.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Duracion");

                    b.Property<string>("Estado");

                    b.Property<DateTime>("Estreno");

                    b.Property<string>("Imagen");

                    b.Property<string>("Nombre");

                    b.Property<string>("Temporadas");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("medias");
                });

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

            modelBuilder.Entity("Model.Relaciones.MediaXActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdActor");

                    b.Property<int>("IdMedia");

                    b.Property<int?>("actorId");

                    b.Property<int?>("mediaId");

                    b.HasKey("Id");

                    b.HasIndex("actorId");

                    b.HasIndex("mediaId");

                    b.ToTable("mediaxactor");
                });

            modelBuilder.Entity("Model.Relaciones.MediaXCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdCategoria");

                    b.Property<int>("IdMedia");

                    b.Property<int?>("categoriaId");

                    b.Property<int?>("mediaId");

                    b.HasKey("Id");

                    b.HasIndex("categoriaId");

                    b.HasIndex("mediaId");

                    b.ToTable("mediaxcategoria");
                });

            modelBuilder.Entity("Model.Comentario", b =>
                {
                    b.HasOne("Model.Media", "media")
                        .WithMany()
                        .HasForeignKey("mediaId");

                    b.HasOne("Model.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaId");
                });

            modelBuilder.Entity("Model.Relaciones.MediaXActor", b =>
                {
                    b.HasOne("Model.Actor", "actor")
                        .WithMany()
                        .HasForeignKey("actorId");

                    b.HasOne("Model.Media", "media")
                        .WithMany()
                        .HasForeignKey("mediaId");
                });

            modelBuilder.Entity("Model.Relaciones.MediaXCategoria", b =>
                {
                    b.HasOne("Model.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaId");

                    b.HasOne("Model.Media", "media")
                        .WithMany()
                        .HasForeignKey("mediaId");
                });
#pragma warning restore 612, 618
        }
    }
}