﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using Peleas.Models;
using System;

namespace Peleas.Migrations
{
    [DbContext(typeof(MvcContext))]
    partial class MvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("Peleas.Models.Control", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos");

                    b.Property<string>("Contraseña");

                    b.Property<string>("Nombre");

                    b.HasKey("ID");

                    b.ToTable("Control");
                });

            modelBuilder.Entity("Peleas.Models.Lucha", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria")
                        .IsRequired();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Descripcion1");

                    b.Property<string>("Descripcion2");

                    b.Property<string>("Descripcion3");

                    b.Property<string>("Diciplina")
                        .IsRequired();

                    b.Property<string>("Fecha")
                        .IsRequired();

                    b.Property<string>("Lugar")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Lucha");
                });

            modelBuilder.Entity("Peleas.Models.Luchador", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos")
                        .IsRequired();

                    b.Property<string>("Categoria")
                        .IsRequired();

                    b.Property<string>("Descripcion1");

                    b.Property<string>("Descripcion2");

                    b.Property<string>("Descripcion3");

                    b.Property<string>("Diciplina")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Luchador");
                });
#pragma warning restore 612, 618
        }
    }
}
