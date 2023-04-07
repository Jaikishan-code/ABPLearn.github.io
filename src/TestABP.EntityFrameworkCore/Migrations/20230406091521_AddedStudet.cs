using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestABP.Migrations
{
    public partial class AddedStudet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "AppStudents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Postalcode",
                table: "AppStudents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AppStudents",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOB",
                table: "AppStudents");

            migrationBuilder.DropColumn(
                name: "Postalcode",
                table: "AppStudents");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AppStudents");
        }
    }
}
