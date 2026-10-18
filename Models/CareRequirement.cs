using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogBreedsApp.Models
{
    public class CareRequirement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string GroomingNeeds { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string ExerciseNeeds { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string TrainingEase { get; set; } = null!;

        [MaxLength(500)]
        public string SpecialDietNotes { get; set; } = null!;

        [ForeignKey(nameof(DogBreed))]
        public int DogBreedId { get; set; }

        public DogBreed DogBreed { get; set; } = null!;
    }
}
