using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookCategorize.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imagelinks",
                columns: table => new
                {
                    smallThumbnail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagelinks", x => x.smallThumbnail);
                });

            migrationBuilder.CreateTable(
                name: "searchBookModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalItems = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_searchBookModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Volumeinfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    publishedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageLinkssmallThumbnail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    previewLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategorizeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volumeinfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Volumeinfo_Imagelinks_imageLinkssmallThumbnail",
                        column: x => x.imageLinkssmallThumbnail,
                        principalTable: "Imagelinks",
                        principalColumn: "smallThumbnail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    selfLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    volumeInfoId = table.Column<int>(type: "int", nullable: false),
                    SearchBookModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_searchBookModels_SearchBookModelId",
                        column: x => x.SearchBookModelId,
                        principalTable: "searchBookModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Volumeinfo_volumeInfoId",
                        column: x => x.volumeInfoId,
                        principalTable: "Volumeinfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_SearchBookModelId",
                table: "Item",
                column: "SearchBookModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_volumeInfoId",
                table: "Item",
                column: "volumeInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Volumeinfo_imageLinkssmallThumbnail",
                table: "Volumeinfo",
                column: "imageLinkssmallThumbnail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "searchBookModels");

            migrationBuilder.DropTable(
                name: "Volumeinfo");

            migrationBuilder.DropTable(
                name: "Imagelinks");
        }
    }
}
