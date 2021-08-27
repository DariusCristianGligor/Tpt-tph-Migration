using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class AddedCookAndDriver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModification",
                table: "Workers",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "NumberOfKm",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialFood",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "LastModification",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "NumberOfKm",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "SpecialFood",
                table: "Workers");
        }
    }
}
