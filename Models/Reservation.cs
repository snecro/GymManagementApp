using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementApp.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required(ErrorMessage = "Please select a workout type")]
        [Display(Name = "Workout type")]
        public TrainingTypesEnum ReservationWorkoutName { get; set; }

        [Required(ErrorMessage = "Please select a reservation day")]
        [Display(Name = "Reservation Day")]
        public DayEnum ReservationDay { get; set; }

        [Range(1, 5)]
        [Required(ErrorMessage = "Please enter at least one member")]
        public int Members { get; set; }

        [ForeignKey("IdentityUser")]
        public string UserId{ get; set; }
        public virtual IdentityUser IdentityUser { get; set; }
    }
}
