using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationAssignmentWeb.Model
{
    public class RegisterUserEventDays
    {
        [Key]
        public int RegisterUserEventDaysId { get; set; }
        public int RegisterUserId { get; set; }
        [ForeignKey("RegisterUserId")]
        public RegisterUser RegisterUser { get; set; }

        public string Days { get; set; }
    }
}
