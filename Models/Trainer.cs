using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementApp.Models
{
    public class Trainer
    {
        [Key]
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public string TrainerPhoto { get; set; }
        public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }
        public string TrainerDescription { get; set; }
        public ICollection<Workout>  Workouts { get; set; }

    }
}
