using GymManagementApp.Data;
using GymManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GymManagementApp.Repositories
{
    public class GymRepository : IGymRepository
    {
        private GymContext _context;

        public GymRepository(GymContext context)
        {
            _context = context;
        }

        public Trainer GetTrainerById(int id)
        {
            return _context.Trainers.SingleOrDefault(a => a.TrainerId == id);
        }

        public Workout GetWorkoutById(int id)
        {
            return _context.Workouts.SingleOrDefault(a => a.WorkoutId == id);
        }

        public IEnumerable<Trainer> GetTrainers()
        {
            return _context.Trainers.ToList();
        }

        public IEnumerable<Workout> GetWorkouts()
        {
            return _context.Workouts.ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Contact GetContact()
        {
            return _context.Contacts.SingleOrDefault();
        }


        public Workout GetWorkoutByTrainer(string name)
        {
            var trainer = _context.Trainers.SingleOrDefault(c => c.TrainerName == name);
            var workout = _context.Workouts.SingleOrDefault(w => w.TrainerId == trainer.TrainerId);
            return workout;

        }
    }
}

