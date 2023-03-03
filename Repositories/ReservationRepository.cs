using GymManagementApp.Data;
using GymManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GymManagementApp.Repositories
{
    public class ReservationRepository: IReservationRepository
    {
        private GymContext _context;

        public ReservationRepository(GymContext context)
        {
            _context = context;
        }
        public void AddReservation(Reservation reservation)
        {
            _context.Add(reservation);
            _context.SaveChanges();
        }

        public void UpdateReservation(Reservation reservation)
        {
            _context.Update(reservation);
            _context.SaveChanges();
        }

        public Reservation GetReservationById(int id)
        {
            return _context.Reservations.SingleOrDefault(a => a.ReservationId == id);
        }

        public void DeleteReservation(int id)
        {
            var reservation = _context.Reservations.SingleOrDefault(c => c.ReservationId == id);
            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
        }
        public IEnumerable<Reservation> GetReservationsByUser(string userID)
        {
            return _context.Reservations.Where( a => a.UserId == userID );
        }
    }
}
