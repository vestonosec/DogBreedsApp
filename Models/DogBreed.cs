using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogBreedsApp.Models
{
    public class DogBreed
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(1000)]
        public string ShortDescription { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string Origin { get; set; } = null!;

        [Range(1, 25)]
        public int AverageLifespanYears { get; set; }

        [Required]
        [MaxLength(30)]
        public string EnergyLevel { get; set; } = null!;

        [Required]
        [Url]
        public string ImageUrl { get; set; } = null!;

        [ForeignKey(nameof(BreedGroup))]
        public int BreedGroupId { get; set; }

        public BreedGroup BreedGroup { get; set; } = null!;

        public CareRequirement? CareRequirement { get; set; }
    }
}
