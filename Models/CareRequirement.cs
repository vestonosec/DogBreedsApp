using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogBreedsApp.Models
{
    public class CareRequirement
    {
        public int Id { get; set; }
        public string GroomingNeeds { get; set; } = null!;
        public string DailyExercise { get; set; } = null!;
        public string TrainingEase { get; set; } = null!;
        public string SpecialDietNotes { get; set; } = null!;

        public ICollection<DogBreed> DogBreeds { get; set; } = new List<DogBreed>();
    }
}
