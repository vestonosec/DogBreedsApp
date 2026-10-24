namespace DogBreedsApp.ViewModels
{
    public class DogBreedDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ShortDescription { get; set; } = null!;
        public string Origin { get; set; } = null!;
        public int AverageLifespanYears { get; set; }
        public int EnergyLevel { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string BreedGroupName { get; set; } = null!;
        public string BreedGroupDescription { get; set; } = null!;
        public string GroomingNeeds { get; set; } = null!;
        public string DailyExercise { get; set; } = null!;
        public string TrainingEase { get; set; } = null!;
        public string SpecialDietNotes { get; set; } = null!;
    }
}
