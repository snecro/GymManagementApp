using GymManagementApp.Data;
using GymManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GymManagementApp.Repositories
{
    public class PricingRepository : IPricingRepository
    { 
        private GymContext _context;

        public PricingRepository(GymContext context)
        {
            _context = context;
        }
    
        public IEnumerable<Pricing> GetPrices()
        {
            return _context.Prices.ToList();
        }
    }
}
