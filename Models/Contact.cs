using System.ComponentModel.DataAnnotations;

namespace GymManagementApp.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactDescription { get; set; }
        public int ContactPhoneNumber { get; set; }
        public string ContactEmail { get; set; }
        public string Location { get; set; }
    }
}
