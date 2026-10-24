using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DogBreedsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDogBreedsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreedGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CareRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroomingNeeds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyExercise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingEase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialDietNotes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DogBreeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageLifespanYears = table.Column<int>(type: "int", nullable: false),
                    EnergyLevel = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreedGroupId = table.Column<int>(type: "int", nullable: false),
                    CareRequirementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogBreeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogBreeds_BreedGroups_BreedGroupId",
                        column: x => x.BreedGroupId,
                        principalTable: "BreedGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DogBreeds_CareRequirements_CareRequirementId",
                        column: x => x.CareRequirementId,
                        principalTable: "CareRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BreedGroups",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Active and alert dogs known for retrieving game and field work.", "Sporting & Retrievers" },
                    { 2, "Intelligent working dogs trained to gather and herd livestock.", "Herding" },
                    { 3, "Small breed dogs primarily kept for companionship and affection.", "Companion / Toy" }
                });

            migrationBuilder.InsertData(
                table: "CareRequirements",
                columns: new[] { "Id", "DailyExercise", "GroomingNeeds", "SpecialDietNotes", "TrainingEase" },
                values: new object[,]
                {
                    { 1, "60+ minutes active exercise", "Weekly brushing, regular bath", "Monitor weight to prevent obesity", "High - very eager to please" },
                    { 2, "90+ minutes intense activity and mental training", "Brush 2-3 times per week, heavy shedding season", "High-protein diet for active dogs", "High - intelligent and disciplined" },
                    { 3, "30 minutes light walks, avoid heat", "Daily cleaning of facial wrinkles, low brushing", "Sensitive stomach, prevent overfeeding", "Moderate - can be stubborn" }
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "AverageLifespanYears", "BreedGroupId", "CareRequirementId", "EnergyLevel", "ImageUrl", "Name", "Origin", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 12, 1, 1, 4, "https://images.unsplash.com/photo-1591769225440-811ad7d6eab2", "Labrador Retriever", "Canada", "Friendly, outgoing, and high-energy companion dog." },
                    { 2, 11, 2, 2, 5, "https://images.unsplash.com/photo-1589941013453-ec89f33b5e95", "German Shepherd", "Germany", "Confident, courageous, and highly intelligent working breed." },
                    { 3, 11, 3, 3, 2, "https://images.unsplash.com/photo-1583511655857-d19b40a7a54e", "French Bulldog", "France", "Playful, adaptable, and affectionate small companion dog." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DogBreeds_BreedGroupId",
                table: "DogBreeds",
                column: "BreedGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DogBreeds_CareRequirementId",
                table: "DogBreeds",
                column: "CareRequirementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogBreeds");

            migrationBuilder.DropTable(
                name: "BreedGroups");

            migrationBuilder.DropTable(
                name: "CareRequirements");
        }
    }
}
