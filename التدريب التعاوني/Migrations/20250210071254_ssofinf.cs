using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineePro.Migrations
{
    /// <inheritdoc />
    public partial class ssofinf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "TestModel",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "TestModel");
        }
    }
}
