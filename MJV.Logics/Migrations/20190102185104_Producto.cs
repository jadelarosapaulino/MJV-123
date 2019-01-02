using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MJV.Logics.Migrations
{
    public partial class Producto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    productoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    productoNombre = table.Column<string>(nullable: true),
                    precio_compra = table.Column<decimal>(nullable: false),
                    precio_venta = table.Column<decimal>(nullable: false),
                    marca_nombre = table.Column<string>(nullable: true),
                    categoria_nombre = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    activo = table.Column<string>(nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.productoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    productoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    activo = table.Column<string>(nullable: false),
                    categoriaID = table.Column<int>(nullable: false),
                    categoria_nombre = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    estadoID = table.Column<int>(nullable: false),
                    fecha_ingreso = table.Column<DateTime>(nullable: false),
                    marcaID = table.Column<int>(nullable: false),
                    marca_nombre = table.Column<string>(nullable: true),
                    precio_compra = table.Column<decimal>(nullable: false),
                    precio_venta = table.Column<decimal>(nullable: false),
                    productoNombre = table.Column<string>(nullable: true),
                    ultima_actualizacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.productoID);
                });
        }
    }
}
