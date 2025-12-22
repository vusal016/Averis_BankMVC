using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Averis.WEBMVC.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LittleTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BigTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FirstText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SecondText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ButtonLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ButtonText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ButtonLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ButtonText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LiTexts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Litext = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AverisAboutId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LiTexts_Abouts_AverisAboutId",
                        column: x => x.AverisAboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LiTexts_AverisAboutId",
                table: "LiTexts",
                column: "AverisAboutId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LiTexts");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
