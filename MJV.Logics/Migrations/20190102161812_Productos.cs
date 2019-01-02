using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MJV.Logics.Migrations
{
    public partial class Productos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    productoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    productoNombre = table.Column<string>(nullable: true),
                    precio_compra = table.Column<decimal>(nullable: false),
                    precio_venta = table.Column<decimal>(nullable: false),
                    marcaID = table.Column<int>(nullable: false),
                    categoriaID = table.Column<int>(nullable: false),
                    estadoID = table.Column<int>(nullable: false),
                    marca_nombre = table.Column<string>(nullable: true),
                    categoria_nombre = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    activo = table.Column<string>(nullable: false),
                    fecha_ingreso = table.Column<DateTime>(nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.productoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
