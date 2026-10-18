using System.ComponentModel.DataAnnotations;

namespace DogBreedsApp.Models
{
    public class BreedGroup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(300)]
        public string Description { get; set; } = null!;

        public ICollection<DogBreed> Breeds { get; set; } = new List<DogBreed>();
    }
}