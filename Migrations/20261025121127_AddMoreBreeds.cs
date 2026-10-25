using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DogBreedsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreBreeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[,]
                {
                    { 6, 13, 1, 1, 4, "https://images.unsplash.com/photo-1537151608828-ea2b11777ee8", "Beagle (Бигъл)", "United Kingdom", "Curious, friendly, and merry hunting hound with great sense of smell." },
                    { 7, 13, 2, 2, 5, "https://images.unsplash.com/photo-1605568427561-40dd23c2acea", "Siberian Husky (Сибирско хъски)", "Russia", "Beautiful, energetic, and resilient sled dog with striking blue or brown eyes." },
                    { 8, 14, 3, 3, 3, "https://images.unsplash.com/photo-1561037404-61cd46aa615b", "Poodle (Пудел)", "France / Germany", "Exceptionally smart, active, and hypoallergenic companion dog." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
