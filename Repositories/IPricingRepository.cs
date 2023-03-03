using GymManagementApp.Models;

namespace GymManagementApp.Repositories
{
    public interface IPricingRepository
    {
        IEnumerable<Pricing> GetPrices();

    }
}
