using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogBreedsApp.Migrations
{
    /// <inheritdoc />
    public partial class FixBeagleAndPoodleImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTINOF_y70BP7qDc3GwGxXsij_DehMSSIfMDsUyKIfiqw&s=10");

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTf6U7Ujasw6-bU2o7QFd_9OHAHxKiaXQA4dP5FbkbHLA&s=10");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1537151608828-ea2b11777ee8");

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1561037404-61cd46aa615b");
        }
    }
}
