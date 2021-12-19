using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookCategorize.Migrations
{
    public partial class RemovedNotUsedAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "previewLink",
                table: "Volumeinfo");

            migrationBuilder.DropColumn(
                name: "publisher",
                table: "Volumeinfo");

            migrationBuilder.DropColumn(
                name: "selfLink",
                table: "Item");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "previewLink",
                table: "Volumeinfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "publisher",
                table: "Volumeinfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "selfLink",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
