using GymManagementApp.Models;
using GymManagementApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GymManagementApp.Controllers
{
    public class WorkoutController : Controller
    {
        private IGymRepository _repository;
        private IWebHostEnvironment _environment;

        public WorkoutController(IGymRepository repository, IWebHostEnvironment environment)
        {
            _environment = environment;
            _repository = repository;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetWorkoutImage(int id)
        {
            Workout requestedWorkout = _repository.GetWorkoutById(id);
            if (requestedWorkout != null)
            {
                string webRootpath = _environment.WebRootPath;
                string folderPath = "\\images\\";
                string fullPath = webRootpath + folderPath + requestedWorkout.WorkoutPhoto;
                if (System.IO.File.Exists(fullPath))
                {
                    FileStream fileOnDisk = new FileStream(fullPath, FileMode.Open);
                    byte[] fileBytes;
                    using (BinaryReader br = new BinaryReader(fileOnDisk))
                    {
                        fileBytes = br.ReadBytes((int)fileOnDisk.Length);
                    }
                    return File(fileBytes, requestedWorkout.ImageMimeType);
                }
                else
                {
                    if (requestedWorkout.PhotoFile.Length > 0)
                    {
                        return File(requestedWorkout.PhotoFile, requestedWorkout.ImageMimeType);
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

    }
}
