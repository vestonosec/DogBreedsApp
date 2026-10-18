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
       
            modelBuilder.Entity<DogBreed>()
                .HasOne(b => b.CareRequirement)
                .WithOne(c => c.DogBreed)
                .HasForeignKey<CareRequirement>(c => c.DogBreedId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BreedGroup>().HasData(
                new BreedGroup { Id = 1, Name = "Sporting & Retrievers", Description = "Active and alert dogs that make great family companions." },
                new BreedGroup { Id = 2, Name = "Herding", Description = "Intelligent working dogs known for their ability to control other animals." },
                new BreedGroup { Id = 3, Name = "Companion / Toy", Description = "Smaller breeds focused on companionship and living indoors." }
            );

            modelBuilder.Entity<DogBreed>().HasData(
                new DogBreed
                {
                    Id = 1,
                    Name = "Labrador Retriever",
                    ShortDescription = "Friendly, outgoing, and high-energy dogs suitable for active families.",
                    Origin = "Canada",
                    AverageLifespanYears = 12,
                    EnergyLevel = "High",
                    ImageUrl = "https://images.unsplash.com/photo-1579783902614-a3fb3927b675",
                    BreedGroupId = 1
                },
                new DogBreed
                {
                    Id = 2,
                    Name = "German Shepherd",
                    ShortDescription = "Smart, courageous, and loyal working breed popular in police and rescue roles.",
                    Origin = "Germany",
                    AverageLifespanYears = 11,
                    EnergyLevel = "Very High",
                    ImageUrl = "https://images.unsplash.com/photo-1589941013453-ec89f33b5e95",
                    BreedGroupId = 2
                },
                new DogBreed
                {
                    Id = 3,
                    Name = "French Bulldog",
                    ShortDescription = "Small, playful, and easygoing companion with iconic bat ears.",
                    Origin = "France",
                    AverageLifespanYears = 11,
                    EnergyLevel = "Medium",
                    ImageUrl = "https://images.unsplash.com/photo-1583511655857-d19b40a7a54e",
                    BreedGroupId = 3
                }
            );

            modelBuilder.Entity<CareRequirement>().HasData(
                new CareRequirement
                {
                    Id = 1,
                    DogBreedId = 1,
                    GroomingNeeds = "Moderate",
                    ExerciseNeeds = "1-2 hours daily",
                    TrainingEase = "Easy",
                    SpecialDietNotes = "Monitor food intake to avoid weight gain."
                },
                new CareRequirement
                {
                    Id = 2,
                    DogBreedId = 2,
                    GroomingNeeds = "High",
                    ExerciseNeeds = "2+ hours daily",
                    TrainingEase = "Easy",
                    SpecialDietNotes = "High-protein diet for active working breed."
                },
                new CareRequirement
                {
                    Id = 3,
                    DogBreedId = 3,
                    GroomingNeeds = "Low",
                    ExerciseNeeds = "30-45 mins daily",
                    TrainingEase = "Moderate",
                    SpecialDietNotes = "Avoid overfeeding; watch out for heat sensitivity."
                }
            );
        }
    }
}