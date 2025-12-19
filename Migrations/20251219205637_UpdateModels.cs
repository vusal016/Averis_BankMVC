using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Averis.WEBMVC.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Litext",
                table: "Abouts",
                newName: "Litexts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Litexts",
                table: "Abouts",
                newName: "Litext");
        }
    }
}
