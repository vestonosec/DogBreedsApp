using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DogBreedsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSelectedBreeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BreedGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Intelligent working dogs trained to gather livestock, guard, or perform search and rescue.", "Herding & Working" });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "ShortDescription",
                value: "Beautiful, energetic, and resilient sled dog with striking eyes.");

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[,]
                {
                    { 9, 13, 3, 3, 2, "https://images.unsplash.com/photo-1517849845537-4d257902454a", "Pug (Мопс)", "China", "Charming, playful, and affectionate toy breed with expressive eyes." },
                    { 10, 12, 1, 2, 4, "https://images.unsplash.com/photo-1583511655826-05700d52f4d9", "Afghan Hound (Афганска хрътка)", "Afghanistan", "Elegantly beautiful, regal, and dignified sighthound with a long coat." },
                    { 11, 15, 3, 3, 3, "https://images.unsplash.com/photo-1560807707-8cc77767d783", "Chihuahua (Чихуахуа)", "Mexico", "Tiny companion with a big personality, fiercely loyal and lively." },
                    { 12, 12, 2, 1, 4, "https://images.unsplash.com/photo-1601758228041-f3b2795255f1", "Bull Terrier (Бултериер)", "United Kingdom", "Playful, muscular, and devoted breed with an iconic egg-shaped head." },
                    { 13, 11, 2, 2, 5, "https://images.unsplash.com/photo-1530281700549-e82e7bf110d6", "Doberman Pinscher (Доберман)", "Germany", "Sleek, powerful, highly intelligent, and fearless guardian dog." },
                    { 14, 10, 2, 2, 4, "https://images.unsplash.com/photo-1567752881298-894bb81f9379", "Rottweiler (Ротвайлер)", "Germany", "Confident, strong, and deeply loyal protector for active families." },
                    { 15, 14, 3, 3, 3, "https://images.unsplash.com/photo-1587300003388-59208cc962cb", "Pomeranian (Померан)", "Germany / Poland", "Fluffy, lively, and inquisitive small dog full of personality." },
                    { 16, 13, 1, 1, 4, "https://images.unsplash.com/photo-1535930891776-0c2dfb7fda1a", "English Cocker Spaniel (Кокер шпаньол)", "United Kingdom", "Gentle, affectionate, and cheerful sporting dog with silky ears." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 13);

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
                table: "BreedGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Intelligent working dogs trained to gather and herd livestock.", "Herding" });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "ShortDescription",
                value: "Beautiful, energetic, and resilient sled dog with striking blue or brown eyes.");
        }
    }
}
