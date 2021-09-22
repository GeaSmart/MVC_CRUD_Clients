using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_CRUD_Clients.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(75)",
                table: "Clients",
                newName: "Nombres");

            migrationBuilder.RenameColumn(
                name: "varchar(50)",
                table: "Clients",
                newName: "Pais");

            migrationBuilder.AlterColumn<string>(
                name: "Nombres",
                table: "Clients",
                type: "varchar(75)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Pais",
                table: "Clients",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "Clients",
                type: "varchar(75)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Departamento",
                table: "Clients",
                type: "varchar(50)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Departamento",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "Pais",
                table: "Clients",
                newName: "varchar(50)");

            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "Clients",
                newName: "varchar(75)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(50)",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "varchar(75)",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(75)");
        }
    }
}
