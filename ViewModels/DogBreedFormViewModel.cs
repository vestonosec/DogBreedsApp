using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DogBreedsApp.ViewModels
{
    public class DogBreedFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Името на породата е задължително.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Името трябва да бъде между 2 и 50 символа.")]
        [Display(Name = "Наименование на породата")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Краткото описание е задължително.")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Описанието трябва да съдържа между 10 и 500 символа.")]
        [Display(Name = "Кратко описание")]
        public string ShortDescription { get; set; } = null!;

        [Required(ErrorMessage = "Страната на произход е задължителна.")]
        [StringLength(50, ErrorMessage = "Страната на произход не може да надвишава 50 символа.")]
        [Display(Name = "Страна на произход")]
        public string Origin { get; set; } = null!;

        [Required(ErrorMessage = "Средната продължителност на живот е задължителна.")]
        [Range(1, 30, ErrorMessage = "Продължителността на живот трябва да е между 1 и 30 години.")]
        [Display(Name = "Средна продължителност на живот (години)")]
        public int AverageLifespanYears { get; set; }

        [Required(ErrorMessage = "Нивото на енергия е задължително.")]
        [Range(1, 5, ErrorMessage = "Нивото на енергия трябва да е от 1 (ниско) до 5 (изключително високо).")]
        [Display(Name = "Ниво на енергия (1-5)")]
        public int EnergyLevel { get; set; }

        [Required(ErrorMessage = "URL адресът на изображението е задължителен.")]
        [Url(ErrorMessage = "Моля, въведете валиден URL адрес.")]
        [Display(Name = "URL на изображение")]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = "Моля, изберете група на породата.")]
        [Display(Name = "Група на породата")]
        public int BreedGroupId { get; set; }

        [Required(ErrorMessage = "Моля, изберете ниво на нуждите от грижа.")]
        [Display(Name = "Изисквания за грижа")]
        public int CareRequirementId { get; set; }

        public IEnumerable<SelectListItem>? BreedGroups { get; set; }
        public IEnumerable<SelectListItem>? CareRequirements { get; set; }
    }
}