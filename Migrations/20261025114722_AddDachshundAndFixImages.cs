using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DogBreedsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDachshundAndFixImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1552053831-71594a27632d");

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[,]
                {
                    { 4, 14, 3, 3, 3, "https://images.unsplash.com/photo-1612195583950-b8fd34c87093", "Dachshund (Дакел)", "Germany", "Clever, lively, and courageous small hound breed." },
                    { 5, 12, 1, 1, 4, "https://images.unsplash.com/photo-1633722715463-d30f4f325e24", "Golden Retriever", "Scotland", "Intelligent, friendly, and devoted sporting family dog." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1591769225440-811ad7d6eab2");
        }
    }
}
