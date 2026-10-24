using DogBreedsApp.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DogBreedsApp.Services
{
    public interface IDogBreedService
    {
        Task<IEnumerable<DogBreedFormViewModel>> GetAllBreedsAsync();
        Task<DogBreedDetailsViewModel?> GetBreedDetailsAsync(int id);
        Task<DogBreedFormViewModel?> GetBreedForEditAsync(int id);
        Task CreateBreedAsync(DogBreedFormViewModel model);
        Task UpdateBreedAsync(DogBreedFormViewModel model);
        Task DeleteBreedAsync(int id);
        Task<IEnumerable<SelectListItem>> GetBreedGroupSelectListAsync();
        Task<IEnumerable<SelectListItem>> GetCareRequirementSelectListAsync();
    }
}
