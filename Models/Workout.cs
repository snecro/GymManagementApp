using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementApp.Models
{
    public class Workout
    {

        [Key]
        public int WorkoutId { get; set; }

        [StringLength(100, MinimumLength = 4)]
        public string WorkoutName { get; set; }
        public string WorkoutPhoto { get; set; }
        public string WorkoutDescription { get; set; }
        public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }
        public int? TrainerId { get; set; }
        public Trainer Trainer { get; set; }

    }
}
