using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationAssignmentWeb.Model
{
    public class RegisterUser
    {
        public RegisterUser()
        {
            RegisterUserEveDays = new HashSet<RegisterUserEventDays>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Address is required.")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        public char Gender { get; set; }

        [Required(ErrorMessage = "Required Date is required.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/mm/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }
               
        [Required(ErrorMessage = "InterestArea is required.")]
        public int InterestArea { get; set; }

        [StringLength(100)]
        public string? AdditionalRequest { get; set; }

        public virtual ICollection<RegisterUserEventDays> RegisterUserEveDays { get; set; }
    }
}