using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DogBreedsApp.Migrations
{
    /// <inheritdoc />
    public partial class FixImagesAndBreeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 11, 2, 2, 5, "https://images.unsplash.com/photo-1530281700549-e82e7bf110d6", "Doberman Pinscher (Доберман)", "Germany", "Sleek, powerful, highly intelligent, and fearless guardian dog." });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 14, 3, 3, 3, "https://images.unsplash.com/photo-1587300003388-59208cc962cb", "Pomeranian (Померан)", "Germany / Poland", "Fluffy, lively, and inquisitive small dog full of personality." });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 12, 1, 2, 4, "https://images.unsplash.com/photo-1583511655826-05700d52f4d9", "Afghan Hound (Афганска хрътка)", "Afghanistan", "Elegantly beautiful, regal, and dignified sighthound with a long coat." });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 4, "https://images.unsplash.com/photo-1543466835-00a7907e9de1", "Miniature Pinscher (Пинчер)", "Germany", "Fearless, energetic, and compact toy breed known as the King of Toys." });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 13, 3, 3, 2, "https://images.unsplash.com/photo-1517849845537-4d257902454a", "Pug (Мопс)", "China", "Charming, playful, and affectionate toy breed with expressive eyes." });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 13, 1, 1, 4, "https://images.unsplash.com/photo-1535930891776-0c2dfb7fda1a", "English Cocker Spaniel (Кокер шпаньол)", "United Kingdom", "Gentle, affectionate, and cheerful sporting dog with silky ears." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 13, 1, 1, 4, "https://images.unsplash.com/photo-1537151608828-ea2b11777ee8", "Beagle (Бигъл)", "United Kingdom", "Curious, friendly, and merry hunting hound with great sense of smell." });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 13, 2, 2, 5, "https://images.unsplash.com/photo-1605568427561-40dd23c2acea", "Siberian Husky (Сибирско хъски)", "Russia", "Beautiful, energetic, and resilient sled dog with striking eyes." });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 14, 3, 3, 3, "https://images.unsplash.com/photo-1561037404-61cd46aa615b", "Poodle (Пудел)", "France / Germany", "Exceptionally smart, active, and hypoallergenic companion dog." });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 2, "https://images.unsplash.com/photo-1517849845537-4d257902454a", "Pug (Мопс)", "China", "Charming, playful, and affectionate toy breed with expressive eyes." });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 12, 1, 2, 4, "https://images.unsplash.com/photo-1583511655826-05700d52f4d9", "Afghan Hound (Афганска хрътка)", "Afghanistan", "Elegantly beautiful, regal, and dignified sighthound with a long coat." });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[] { 11, 2, 2, 5, "https://images.unsplash.com/photo-1530281700549-e82e7bf110d6", "Doberman Pinscher (Доберман)", "Germany", "Sleek, powerful, highly intelligent, and fearless guardian dog." });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[,]
                {
                    { 14, 10, 2, 2, 4, "https://images.unsplash.com/photo-1567752881298-894bb81f9379", "Rottweiler (Ротвайлер)", "Germany", "Confident, strong, and deeply loyal protector for active families." },
                    { 15, 14, 3, 3, 3, "https://images.unsplash.com/photo-1587300003388-59208cc962cb", "Pomeranian (Померан)", "Germany / Poland", "Fluffy, lively, and inquisitive small dog full of personality." },
                    { 16, 13, 1, 1, 4, "https://images.unsplash.com/photo-1535930891776-0c2dfb7fda1a", "English Cocker Spaniel (Кокер шпаньол)", "United Kingdom", "Gentle, affectionate, and cheerful sporting dog with silky ears." }
                });
        }
    }
}
