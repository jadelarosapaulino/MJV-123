﻿// <auto-generated />
using System;
using MJV.Logics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MJV.Logics.Migrations
{
    [DbContext(typeof(MJVContext))]
    [Migration("20190102185104_Producto")]
    partial class Producto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MJV.Logics.Models.Producto", b =>
                {
                    b.Property<int>("productoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("activo")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("categoria_nombre");

                    b.Property<string>("estado");

                    b.Property<string>("marca_nombre");

                    b.Property<decimal>("precio_compra");

                    b.Property<decimal>("precio_venta");

                    b.Property<string>("productoNombre");

                    b.Property<DateTime>("ultima_actualizacion");

                    b.HasKey("productoID");

                    b.ToTable("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
