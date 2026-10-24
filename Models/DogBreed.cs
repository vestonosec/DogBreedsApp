using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogBreedsApp.Models
{
    public class DogBreed
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ShortDescription { get; set; } = null!;
        public string Origin { get; set; } = null!;
        public int AverageLifespanYears { get; set; }
        public int EnergyLevel { get; set; }
        public string ImageUrl { get; set; } = null!;

        public int BreedGroupId { get; set; }
        public BreedGroup BreedGroup { get; set; } = null!;

        public int CareRequirementId { get; set; }
        public CareRequirement CareRequirement { get; set; } = null!;
    }
}
