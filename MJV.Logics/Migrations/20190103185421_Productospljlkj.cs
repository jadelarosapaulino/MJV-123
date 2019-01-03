using Microsoft.EntityFrameworkCore.Migrations;

namespace MJV.Logics.Migrations
{
    public partial class Productospljlkj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoriaID",
                table: "Producto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "estadoID",
                table: "Producto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "marcaID",
                table: "Producto",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoriaID",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "estadoID",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "marcaID",
                table: "Producto");
        }
    }
}
