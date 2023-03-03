using GymManagementApp.Models;
using GymManagementApp.Repositories;
using GymManagementApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GymManagementApp.Controllers
{
    public class HomeController : Controller
    {
        
        private IGymRepository _repository;
        private IWebHostEnvironment _environment;

        public HomeController(IGymRepository repository,IWebHostEnvironment environment)
        {
            _environment = environment;
            _repository = repository;

        }

        [HttpGet]
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel();
            vm.Workouts = _repository.GetWorkouts();
            return View(vm);
        }

        [HttpGet]
        public IActionResult Location()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Services()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BookNow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Trainers()
        {
            return View(_repository.GetTrainers());
        }

        [HttpGet]
        public IActionResult WorkoutSearch()
        {
            ViewBag.TrainersName = new List<string>() { "Carmen Serban", "Liam Smith", "James Robert", "Patricia Anderson", "Mateo Rossi" };
            return View();
        }
        [HttpPost]
        public IActionResult WorkoutSearch(Trainer trainer)
        {
            string name = trainer.TrainerName;
            var workout = _repository.GetWorkoutByTrainer(name);
            return View("WorkoutName",workout);
        }

        public IActionResult GetImage(int id)
        {
            Trainer requestedTrainer = _repository.GetTrainerById(id);
            if (requestedTrainer != null)
            {
                string webRootpath = _environment.WebRootPath;
                string folderPath = "\\images\\";
                string fullPath = webRootpath + folderPath + requestedTrainer.TrainerPhoto;
                if (System.IO.File.Exists(fullPath))
                {
                    FileStream fileOnDisk = new FileStream(fullPath, FileMode.Open);
                    byte[] fileBytes;
                    using (BinaryReader br = new BinaryReader(fileOnDisk))
                    {
                        fileBytes = br.ReadBytes((int)fileOnDisk.Length);
                    }
                    return File(fileBytes, requestedTrainer.ImageMimeType);
                }
                else
                {
                    if (requestedTrainer.PhotoFile.Length > 0)
                    {
                        return File(requestedTrainer.PhotoFile, requestedTrainer.ImageMimeType);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
            else
            {
                return NotFound();
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}