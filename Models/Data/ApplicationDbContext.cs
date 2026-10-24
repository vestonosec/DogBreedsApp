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

            // Seed BreedGroups
            modelBuilder.Entity<BreedGroup>().HasData(
                new BreedGroup { Id = 1, Name = "Sporting & Retrievers", Description = "Active and alert dogs known for retrieving game and field work." },
                new BreedGroup { Id = 2, Name = "Herding", Description = "Intelligent working dogs trained to gather and herd livestock." },
                new BreedGroup { Id = 3, Name = "Companion / Toy", Description = "Small breed dogs primarily kept for companionship and affection." }
            );

            // Seed CareRequirements
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

            // Seed DogBreeds
            modelBuilder.Entity<DogBreed>().HasData(
                new DogBreed
                {
                    Id = 1,
                    Name = "Labrador Retriever",
                    ShortDescription = "Friendly, outgoing, and high-energy companion dog.",
                    Origin = "Canada",
                    AverageLifespanYears = 12,
                    EnergyLevel = 4,
                    ImageUrl = "https://images.unsplash.com/photo-1591769225440-811ad7d6eab2",
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
                }
            );
        }
    }
}