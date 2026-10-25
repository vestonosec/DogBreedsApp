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
                new BreedGroup { Id = 2, Name = "Herding & Working", Description = "Intelligent working dogs trained to gather livestock, guard, or perform search and rescue." },
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
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTINOF_y70BP7qDc3GwGxXsij_DehMSSIfMDsUyKIfiqw&s=10",
                    BreedGroupId = 1,
                    CareRequirementId = 1
                },
                new DogBreed
                {
                    Id = 7,
                    Name = "Siberian Husky (Сибирско хъски)",
                    ShortDescription = "Beautiful, energetic, and resilient sled dog with striking eyes.",
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
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTf6U7Ujasw6-bU2o7QFd_9OHAHxKiaXQA4dP5FbkbHLA&s=10",
                    BreedGroupId = 3,
                    CareRequirementId = 3
                },
                new DogBreed
                {
                    Id = 9,
                    Name = "Pug (Мопс)",
                    ShortDescription = "Charming, playful, and affectionate toy breed with expressive eyes.",
                    Origin = "China",
                    AverageLifespanYears = 13,
                    EnergyLevel = 2,
                    ImageUrl = "https://images.unsplash.com/photo-1517849845537-4d257902454a",
                    BreedGroupId = 3,
                    CareRequirementId = 3
                },
                new DogBreed
                {
                    Id = 10,
                    Name = "Afghan Hound (Афганска хрътка)",
                    ShortDescription = "Elegantly beautiful, regal, and dignified sighthound with a long coat.",
                    Origin = "Afghanistan",
                    AverageLifespanYears = 12,
                    EnergyLevel = 4,
                    ImageUrl = "https://www.zoomalia.com/blogz/3431/tout-savoir-sur-levrier-afghan.jpeg",
                    BreedGroupId = 1,
                    CareRequirementId = 2
                },
                new DogBreed
                {
                    Id = 11,
                    Name = "Chihuahua (Чихуахуа)",
                    ShortDescription = "Tiny companion with a big personality, fiercely loyal and lively.",
                    Origin = "Mexico",
                    AverageLifespanYears = 15,
                    EnergyLevel = 3,
                    ImageUrl = "https://images.unsplash.com/photo-1560807707-8cc77767d783",
                    BreedGroupId = 3,
                    CareRequirementId = 3
                },
                new DogBreed
                {
                    Id = 12,
                    Name = "Bull Terrier (Бултериер)",
                    ShortDescription = "Playful, muscular, and devoted breed with an iconic egg-shaped head.",
                    Origin = "United Kingdom",
                    AverageLifespanYears = 12,
                    EnergyLevel = 4,
                    ImageUrl = "https://images.unsplash.com/photo-1601758228041-f3b2795255f1",
                    BreedGroupId = 2,
                    CareRequirementId = 1
                },
                new DogBreed
                {
                    Id = 13,
                    Name = "Doberman Pinscher (Доберман)",
                    ShortDescription = "Sleek, powerful, highly intelligent, and fearless guardian dog.",
                    Origin = "Germany",
                    AverageLifespanYears = 11,
                    EnergyLevel = 5,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSKry-6yfxN038QLTs5pI_34kpldhXi_Q7tUGcOEDegBQ&s=10",
                    BreedGroupId = 2,
                    CareRequirementId = 2
                },
                new DogBreed
                {
                    Id = 14,
                    Name = "Rottweiler (Ротвайлер)",
                    ShortDescription = "Confident, strong, and deeply loyal protector for active families.",
                    Origin = "Germany",
                    AverageLifespanYears = 10,
                    EnergyLevel = 4,
                    ImageUrl = "https://images.unsplash.com/photo-1567752881298-894bb81f9379",
                    BreedGroupId = 2,
                    CareRequirementId = 2
                },
                new DogBreed
                {
                    Id = 15,
                    Name = "Pomeranian (Померан)",
                    ShortDescription = "Fluffy, lively, and inquisitive small dog full of personality.",
                    Origin = "Germany / Poland",
                    AverageLifespanYears = 14,
                    EnergyLevel = 3,
                    ImageUrl = "https://cdn5.amwws.com/a/pomerani.alle.bg/assets/dd196b20691b-c999999999/ahxedo2wblj2fha43u3mjiu.jpg",
                    BreedGroupId = 3,
                    CareRequirementId = 3
                },
                new DogBreed
                {
                    Id = 16,
                    Name = "Miniature Pinscher (Пинчер)",
                    ShortDescription = "Fearless, energetic, and compact toy breed known as the King of Toys.",
                    Origin = "Germany",
                    AverageLifespanYears = 13,
                    EnergyLevel = 4,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ2DOMTB19nYEmMWzBVvUi3H4tibGxE6PnHMT97D_wAAQ&s=10",
                    BreedGroupId = 3,
                    CareRequirementId = 3
                },
                new DogBreed
                {
                    Id = 17,
                    Name = "English Cocker Spaniel (Кокер шпаньол)",
                    ShortDescription = "Gentle, affectionate, and cheerful sporting dog with silky ears.",
                    Origin = "United Kingdom",
                    AverageLifespanYears = 13,
                    EnergyLevel = 4,
                    ImageUrl = "https://images.unsplash.com/photo-1535930891776-0c2dfb7fda1a",
                    BreedGroupId = 1,
                    CareRequirementId = 1
                }
            );
        }
    }
}