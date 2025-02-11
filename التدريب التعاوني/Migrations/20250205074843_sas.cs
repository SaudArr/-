using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineePro.Migrations
{
    /// <inheritdoc />
    public partial class sas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UniversityID",
                table: "TestModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "TestModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Collage",
                table: "TestModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TestModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "TestModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "TestModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "TestModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TrainingEndDate",
                table: "TestModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TrainingLetter",
                table: "TestModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "TrainingStartDate",
                table: "TestModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "TestModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "TestModel");

            migrationBuilder.DropColumn(
                name: "Collage",
                table: "TestModel");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TestModel");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "TestModel");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "TestModel");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "TestModel");

            migrationBuilder.DropColumn(
                name: "TrainingEndDate",
                table: "TestModel");

            migrationBuilder.DropColumn(
                name: "TrainingLetter",
                table: "TestModel");

            migrationBuilder.DropColumn(
                name: "TrainingStartDate",
                table: "TestModel");

            migrationBuilder.DropColumn(
                name: "University",
                table: "TestModel");

            migrationBuilder.AlterColumn<string>(
                name: "UniversityID",
                table: "TestModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
