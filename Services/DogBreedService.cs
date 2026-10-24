using DogBreedsApp.Data;
using DogBreedsApp.Models;
using DogBreedsApp.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DogBreedsApp.Services
{
    public class DogBreedService : IDogBreedService
    {
        private readonly ApplicationDbContext _context;

        public DogBreedService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DogBreedFormViewModel>> GetAllBreedsAsync()
        {
            return await _context.DogBreeds
                .AsNoTracking()
                .Select(b => new DogBreedFormViewModel
                {
                    Id = b.Id,
                    Name = b.Name,
                    ShortDescription = b.ShortDescription,
                    Origin = b.Origin,
                    AverageLifespanYears = b.AverageLifespanYears,
                    EnergyLevel = b.EnergyLevel,
                    ImageUrl = b.ImageUrl,
                    BreedGroupId = b.BreedGroupId,
                    CareRequirementId = b.CareRequirementId
                })
                .ToListAsync();
        }

        public async Task<DogBreedDetailsViewModel?> GetBreedDetailsAsync(int id)
        {
            return await _context.DogBreeds
                .AsNoTracking()
                .Include(b => b.BreedGroup)
                .Include(b => b.CareRequirement)
                .Where(b => b.Id == id)
                .Select(b => new DogBreedDetailsViewModel
                {
                    Id = b.Id,
                    Name = b.Name,
                    ShortDescription = b.ShortDescription,
                    Origin = b.Origin,
                    AverageLifespanYears = b.AverageLifespanYears,
                    EnergyLevel = b.EnergyLevel,
                    ImageUrl = b.ImageUrl,
                    BreedGroupName = b.BreedGroup.Name,
                    BreedGroupDescription = b.BreedGroup.Description,
                    GroomingNeeds = b.CareRequirement.GroomingNeeds,
                    DailyExercise = b.CareRequirement.DailyExercise,
                    TrainingEase = b.CareRequirement.TrainingEase,
                    SpecialDietNotes = b.CareRequirement.SpecialDietNotes
                })
                .FirstOrDefaultAsync();
        }

        public async Task<DogBreedFormViewModel?> GetBreedForEditAsync(int id)
        {
            var breed = await _context.DogBreeds.FindAsync(id);
            if (breed == null) return null;

            return new DogBreedFormViewModel
            {
                Id = breed.Id,
                Name = breed.Name,
                ShortDescription = breed.ShortDescription,
                Origin = breed.Origin,
                AverageLifespanYears = breed.AverageLifespanYears,
                EnergyLevel = breed.EnergyLevel,
                ImageUrl = breed.ImageUrl,
                BreedGroupId = breed.BreedGroupId,
                CareRequirementId = breed.CareRequirementId
            };
        }

        public async Task CreateBreedAsync(DogBreedFormViewModel model)
        {
            var breed = new DogBreed
            {
                Name = model.Name,
                ShortDescription = model.ShortDescription,
                Origin = model.Origin,
                AverageLifespanYears = model.AverageLifespanYears,
                EnergyLevel = model.EnergyLevel,
                ImageUrl = model.ImageUrl,
                BreedGroupId = model.BreedGroupId,
                CareRequirementId = model.CareRequirementId
            };

            await _context.DogBreeds.AddAsync(breed);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBreedAsync(DogBreedFormViewModel model)
        {
            var breed = await _context.DogBreeds.FindAsync(model.Id);
            if (breed == null) return;

            breed.Name = model.Name;
            breed.ShortDescription = model.ShortDescription;
            breed.Origin = model.Origin;
            breed.AverageLifespanYears = model.AverageLifespanYears;
            breed.EnergyLevel = model.EnergyLevel;
            breed.ImageUrl = model.ImageUrl;
            breed.BreedGroupId = model.BreedGroupId;
            breed.CareRequirementId = model.CareRequirementId;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteBreedAsync(int id)
        {
            var breed = await _context.DogBreeds.FindAsync(id);
            if (breed != null)
            {
                _context.DogBreeds.Remove(breed);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetBreedGroupSelectListAsync()
        {
            return await _context.BreedGroups
                .AsNoTracking()
                .Select(g => new SelectListItem
                {
                    Value = g.Id.ToString(),
                    Text = g.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<SelectListItem>> GetCareRequirementSelectListAsync()
        {
            return await _context.CareRequirements
                .AsNoTracking()
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = $"Grooming: {c.GroomingNeeds} | Exercise: {c.DailyExercise}"
                })
                .ToListAsync();
        }
    }
}
