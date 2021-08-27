using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class MigrationWithTph : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cooks_Workers_Id",
                table: "Cooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Workers_Id",
                table: "Drivers");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModification",
                table: "Drivers",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "Wage",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModification",
                table: "Cooks",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "Wage",
                table: "Cooks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastModification",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Wage",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "LastModification",
                table: "Cooks");

            migrationBuilder.DropColumn(
                name: "Wage",
                table: "Cooks");

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModification = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Wage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cooks_Workers_Id",
                table: "Cooks",
                column: "Id",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Workers_Id",
                table: "Drivers",
                column: "Id",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
