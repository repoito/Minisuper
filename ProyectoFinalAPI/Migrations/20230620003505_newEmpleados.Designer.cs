﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinalAPI.Data;

#nullable disable

namespace ProyectoFinalAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230620003505_newEmpleados")]
    partial class newEmpleados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoFinalAPI.Models.Empleadoo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Mario Hernandez",
                            Password = "12345",
                            UserName = "Mario"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Roberto Sanchez",
                            Password = "123456",
                            UserName = "Roberto"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Pepito Juarez",
                            Password = "1234567",
                            UserName = "Pepito"
                        });
                });

            modelBuilder.Entity("ProyectoFinalAPI.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<int>("Existencia")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("TipoProducto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            IdProducto = 1,
                            Existencia = 500,
                            Marca = "Bimbo",
                            Precio = 98.0,
                            TipoProducto = "Pan"
                        },
                        new
                        {
                            IdProducto = 2,
                            Existencia = 500,
                            Marca = "Cocacola 3L",
                            Precio = 60.0,
                            TipoProducto = "Refresco"
                        },
                        new
                        {
                            IdProducto = 3,
                            Existencia = 500,
                            Marca = "Eskimo",
                            Precio = 98.0,
                            TipoProducto = "Leche"
                        },
                        new
                        {
                            IdProducto = 4,
                            Existencia = 2000,
                            Marca = "McCormi",
                            Precio = 72.0,
                            TipoProducto = "Aderezo Ranch"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
