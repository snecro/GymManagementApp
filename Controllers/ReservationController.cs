using GymManagementApp.Models;
using GymManagementApp.Repositories;
using GymManagementApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GymManagementApp.Controllers
{
    public class ReservationController : Controller
    {
        private IReservationRepository _repository;
        private IWebHostEnvironment _environment;
        private readonly IHttpContextAccessor _httpContext;


        public ReservationController(IReservationRepository repository, IWebHostEnvironment environment, IHttpContextAccessor httpContext)
        {
            _environment = environment;
            _repository = repository;
            _httpContext = httpContext;
        }

        public string GetUserId()
        {
            return _httpContext.HttpContext.User?.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        [HttpGet]
        public ViewResult CreateReservation()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
                return View("Authentication");
        }

        [HttpPost]
        public RedirectToActionResult CreateReservation(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                var user = GetUserId();
                reservation.UserId = user;
                _repository.AddReservation(reservation);
                return RedirectToAction("details", new { id = reservation.ReservationId });
            }

            return RedirectToAction("CreateReservation");
        }

        [HttpGet]
        public ViewResult EditReservation(int id)
        {
           Reservation reservation = _repository.GetReservationById(id);
            
            return View(reservation);
        }

        [HttpPost]
        public IActionResult EditReservation(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                Reservation rs = _repository.GetReservationById(reservation.ReservationId);
                rs.ReservationWorkoutName = reservation.ReservationWorkoutName;
                rs.Members = reservation.Members;

                 _repository.UpdateReservation(rs);
                return View("UpdateReservationMessage");
            }
            return RedirectToAction("CreateReservation");
        }

        public IActionResult Details (int id)
        {
            ReservationDetailsViewModel reservationDetailsViewModel = new ReservationDetailsViewModel();
            {
                Reservation reservation = _repository.GetReservationById(id);
                reservationDetailsViewModel.Reservation = reservation;
            }
            return View(reservationDetailsViewModel);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            _repository.DeleteReservation(id);
            return View();
            
        }

        [HttpGet]
        public IActionResult GetReservationsByUser(string userID)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                var user = GetUserId();
                var reservation = _repository.GetReservationsByUser(user);
                if (!reservation.Any())
                {
                    return View("NoReservation");
                }
                else
                return View(_repository.GetReservationsByUser(user));
            }
            else
            {
                return View("Authentication");
            }
        }


    }
}
