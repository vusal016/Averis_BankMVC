using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Averis.WEBMVC.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LittleTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BigTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
