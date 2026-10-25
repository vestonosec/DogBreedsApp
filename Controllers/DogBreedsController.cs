using DogBreedsApp.Services;
using DogBreedsApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DogBreedsApp.Controllers
{
    public class DogBreedsController : Controller
    {
        private readonly IDogBreedService _breedService;

        public DogBreedsController(IDogBreedService breedService)
        {
            _breedService = breedService;
        }

        public async Task<IActionResult> Index(string? searchString, int? breedGroupId)
        {
            ViewBag.CurrentSearch = searchString;
            ViewBag.CurrentGroup = breedGroupId;
            ViewBag.BreedGroups = await _breedService.GetBreedGroupSelectListAsync();

            var breeds = await _breedService.GetAllBreedsAsync(searchString, breedGroupId);
            return View(breeds);
        }

        public async Task<IActionResult> Details(int id)
        {
            var breed = await _breedService.GetBreedDetailsAsync(id);
            if (breed == null)
            {
                return NotFound();
            }

            return View(breed);
        }

        public async Task<IActionResult> Create()
        {
            var model = new DogBreedFormViewModel
            {
                BreedGroups = await _breedService.GetBreedGroupSelectListAsync(),
                CareRequirements = await _breedService.GetCareRequirementSelectListAsync()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DogBreedFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.BreedGroups = await _breedService.GetBreedGroupSelectListAsync();
                model.CareRequirements = await _breedService.GetCareRequirementSelectListAsync();
                return View(model);
            }

            await _breedService.CreateBreedAsync(model);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = await _breedService.GetBreedForEditAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            model.BreedGroups = await _breedService.GetBreedGroupSelectListAsync();
            model.CareRequirements = await _breedService.GetCareRequirementSelectListAsync();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DogBreedFormViewModel model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                model.BreedGroups = await _breedService.GetBreedGroupSelectListAsync();
                model.CareRequirements = await _breedService.GetCareRequirementSelectListAsync();
                return View(model);
            }

            await _breedService.UpdateBreedAsync(model);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var breed = await _breedService.GetBreedDetailsAsync(id);
            if (breed == null)
            {
                return NotFound();
            }

            return View(breed);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _breedService.DeleteBreedAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}