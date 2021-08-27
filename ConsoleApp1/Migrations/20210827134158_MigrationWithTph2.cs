using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class MigrationWithTph2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.RenameTable(
                name: "Drivers",
                newName: "Workers");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfKm",
                table: "Workers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpecialFood",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workers",
                table: "Workers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Workers",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "SpecialFood",
                table: "Workers");

            migrationBuilder.RenameTable(
                name: "Workers",
                newName: "Drivers");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfKm",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModification = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SpecialFood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooks", x => x.Id);
                });
        }
    }
}
