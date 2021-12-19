using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookCategorize.Migrations
{
    public partial class RatingAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Volumeinfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Volumeinfo");
        }
    }
}
