using GymManagementApp.Models;

namespace GymManagementApp.Repositories
{
    public interface IReservationRepository
    {
        void AddReservation(Reservation reservation);

        Reservation GetReservationById(int id);

        void DeleteReservation(int id);

        void UpdateReservation(Reservation reservation);

        IEnumerable<Reservation> GetReservationsByUser(string userID);
    }
}
