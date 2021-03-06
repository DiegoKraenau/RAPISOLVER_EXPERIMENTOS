﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RapiSolver.Repository.context;

namespace RapiSolver.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191015031838_Init6")]
    partial class Init6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RapiSolver.Entity.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("RapiSolver.Entity.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Email");

                    b.Property<string>("Genger");

                    b.Property<string>("LastName");

                    b.Property<int>("LocationId");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<int>("UsuarioId");

                    b.HasKey("CustomerId");

                    b.HasIndex("LocationId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("RapiSolver.Entity.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("State");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("RapiSolver.Entity.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RolDescription");

                    b.Property<int>("UsuarioId");

                    b.HasKey("RolId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("RapiSolver.Entity.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Email");

                    b.Property<string>("Genger");

                    b.Property<string>("LastName");

                    b.Property<int>("LocationId");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<int>("UsuarioId");

                    b.HasKey("SupplierId");

                    b.HasIndex("LocationId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("suppliers");
                });

            modelBuilder.Entity("RapiSolver.Entity.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.HasKey("UsuarioId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("RapiSolver.Entity.Customer", b =>
                {
                    b.HasOne("RapiSolver.Entity.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RapiSolver.Entity.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RapiSolver.Entity.Rol", b =>
                {
                    b.HasOne("RapiSolver.Entity.Usuario", "Usuario")
                        .WithMany("Roles")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RapiSolver.Entity.Supplier", b =>
                {
                    b.HasOne("RapiSolver.Entity.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RapiSolver.Entity.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
