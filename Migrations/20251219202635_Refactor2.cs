using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Averis.WEBMVC.Migrations
{
    /// <inheritdoc />
    public partial class Refactor2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LiText",
                table: "Abouts",
                newName: "Litext");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Litext",
                table: "Abouts",
                newName: "LiText");
        }
    }
}
