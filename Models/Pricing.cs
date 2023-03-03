using System.ComponentModel.DataAnnotations;

namespace GymManagementApp.Models
{
    public class Pricing
    {
        [Key]
        public int PricingId { get; set; }
        public string Subscription { get; set; }
        public string PricingDescription { get; set; }
        public int Price { get; set; }
    }
}
