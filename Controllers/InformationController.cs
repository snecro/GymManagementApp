using GymManagementApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GymManagementApp.Controllers
{
    public class InformationController : Controller
    {
        private IGymRepository _repository;
        private IWebHostEnvironment _environment;

        public InformationController(IGymRepository repository, IWebHostEnvironment environment)
        {
            _environment = environment;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View(_repository.GetContact());
        }


        [HttpGet]
        public IActionResult Schedule()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Pricing()
        {
            return View();
        }

    }


        
}
