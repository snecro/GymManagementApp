using GymManagementApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GymManagementApp.Controllers
{
    public class PricingController : Controller
    {
        private IPricingRepository _repository;
        private IWebHostEnvironment _environment;

        public PricingController(IPricingRepository repository, IWebHostEnvironment environment)
        {
            _environment = environment;
            _repository = repository;

        }

        [HttpGet]
        public IActionResult Pricing()
        {
            return View(_repository.GetPrices());
        }
    }
}
