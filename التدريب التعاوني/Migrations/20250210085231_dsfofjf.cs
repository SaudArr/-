using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineePro.Migrations
{
    /// <inheritdoc />
    public partial class dsfofjf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "TestModel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "TestModel",
                type: "int",
                nullable: true);
        }
    }
}
