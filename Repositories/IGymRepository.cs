using GymManagementApp.Models;

namespace GymManagementApp.Repositories
{
    public interface IGymRepository
    {
        IEnumerable<Trainer> GetTrainers();

        void SaveChanges();

        Trainer GetTrainerById(int id);

        IEnumerable<Workout> GetWorkouts();

        Workout GetWorkoutById(int id);

        Contact GetContact();

        Workout GetWorkoutByTrainer(string name);

    }
}
