using DogBreedsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DogBreedsApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DogBreed> DogBreeds { get; set; } = null!;
        public DbSet<BreedGroup> BreedGroups { get; set; } = null!;
        public DbSet<CareRequirement> CareRequirements { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BreedGroup>().HasData(
                new BreedGroup { Id = 1, Name = "Sporting & Retrievers", Description = "Active and alert dogs known for retrieving game and field work." },
                new BreedGroup { Id = 2, Name = "Herding", Description = "Intelligent working dogs trained to gather and herd livestock." },
                new BreedGroup { Id = 3, Name = "Companion / Toy", Description = "Small breed dogs primarily kept for companionship and affection." }
            );

            modelBuilder.Entity<CareRequirement>().HasData(
                new CareRequirement
                {
                    Id = 1,
                    GroomingNeeds = "Weekly brushing, regular bath",
                    DailyExercise = "60+ minutes active exercise",
                    TrainingEase = "High - very eager to please",
                    SpecialDietNotes = "Monitor weight to prevent obesity"
                },
                new CareRequirement
                {
                    Id = 2,
                    GroomingNeeds = "Brush 2-3 times per week, heavy shedding season",
                    DailyExercise = "90+ minutes intense activity and mental training",
                    TrainingEase = "High - intelligent and disciplined",
                    SpecialDietNotes = "High-protein diet for active dogs"
                },
                new CareRequirement
                {
                    Id = 3,
                    GroomingNeeds = "Daily cleaning of facial wrinkles, low brushing",
                    DailyExercise = "30 minutes light walks, avoid heat",
                    TrainingEase = "Moderate - can be stubborn",
                    SpecialDietNotes = "Sensitive stomach, prevent overfeeding"
                }
            );
            modelBuilder.Entity<DogBreed>().HasData(
                new DogBreed
                {
                    Id = 1,
                    Name = "Labrador Retriever",
                    ShortDescription = "Friendly, outgoing, and high-energy companion dog.",
                    Origin = "Canada",
                    AverageLifespanYears = 12,
                    EnergyLevel = 4,
                    ImageUrl = "https://images.unsplash.com/photo-1552053831-71594a27632d",
                    BreedGroupId = 1,
                    CareRequirementId = 1
                },
                new DogBreed
                {
                    Id = 2,
                    Name = "German Shepherd",
                    ShortDescription = "Confident, courageous, and highly intelligent working breed.",
                    Origin = "Germany",
                    AverageLifespanYears = 11,
                    EnergyLevel = 5,
                    ImageUrl = "https://images.unsplash.com/photo-1589941013453-ec89f33b5e95",
                    BreedGroupId = 2,
                    CareRequirementId = 2
                },
                new DogBreed
                {
                    Id = 3,
                    Name = "French Bulldog",
                    ShortDescription = "Playful, adaptable, and affectionate small companion dog.",
                    Origin = "France",
                    AverageLifespanYears = 11,
                    EnergyLevel = 2,
                    ImageUrl = "https://images.unsplash.com/photo-1583511655857-d19b40a7a54e",
                    BreedGroupId = 3,
                    CareRequirementId = 3
                },
                new DogBreed
                {
                    Id = 4,
                    Name = "Dachshund (Дакел)",
                    ShortDescription = "Clever, lively, and courageous small hound breed.",
                    Origin = "Germany",
                    AverageLifespanYears = 14,
                    EnergyLevel = 3,
                    ImageUrl = "https://images.unsplash.com/photo-1612195583950-b8fd34c87093",
                    BreedGroupId = 3,
                    CareRequirementId = 3
                },
                new DogBreed
                {
                    Id = 5,
                    Name = "Golden Retriever",
                    ShortDescription = "Intelligent, friendly, and devoted sporting family dog.",
                    Origin = "Scotland",
                    AverageLifespanYears = 12,
                    EnergyLevel = 4,
                    ImageUrl = "https://images.unsplash.com/photo-1633722715463-d30f4f325e24",
                    BreedGroupId = 1,
                    CareRequirementId = 1
                },
                new DogBreed
                {
                    Id = 6,
                    Name = "Beagle (Бигъл)",
                    ShortDescription = "Curious, friendly, and merry hunting hound with great sense of smell.",
                    Origin = "United Kingdom",
                    AverageLifespanYears = 13,
                    EnergyLevel = 4,
                    ImageUrl = "https://images.unsplash.com/photo-1537151608828-ea2b11777ee8",
                    BreedGroupId = 1,
                    CareRequirementId = 1
                },
                new DogBreed
                {
                    Id = 7,
                    Name = "Siberian Husky (Сибирско хъски)",
                    ShortDescription = "Beautiful, energetic, and resilient sled dog with striking blue or brown eyes.",
                    Origin = "Russia",
                    AverageLifespanYears = 13,
                    EnergyLevel = 5,
                    ImageUrl = "https://images.unsplash.com/photo-1605568427561-40dd23c2acea",
                    BreedGroupId = 2,
                    CareRequirementId = 2
                },
                new DogBreed
                {
                    Id = 8,
                    Name = "Poodle (Пудел)",
                    ShortDescription = "Exceptionally smart, active, and hypoallergenic companion dog.",
                    Origin = "France / Germany",
                    AverageLifespanYears = 14,
                    EnergyLevel = 3,
                    ImageUrl = "https://images.unsplash.com/photo-1561037404-61cd46aa615b",
                    BreedGroupId = 3,
                    CareRequirementId = 3
                }
            );
        }
    }
}