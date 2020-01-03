using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppTest.Migrations
{
    public partial class RemoveImageClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Images_ImageId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ImageId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "PosterPath",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PosterPath",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ImageId",
                table: "Movies",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Images_ImageId",
                table: "Movies",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
