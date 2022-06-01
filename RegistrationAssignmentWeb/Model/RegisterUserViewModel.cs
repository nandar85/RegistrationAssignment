using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationAssignmentWeb.Model
{
    public class RegisterUserViewModel
    {
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
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/mm/yyyy}")]
        [Display(Name = "Date Registered")]
        public DateTime? RegisterDate { get; set; }

        [Required(ErrorMessage = "InterestArea is required.")]
        public int InterestArea { get; set; }

        [StringLength(100)]
        [Display(Name = "Additial Request")]
        public string? AdditionalRequest { get; set; }

        [Required(ErrorMessage = "Event Day is required.")]
        [Display(Name = "Selected Days")]
        public string[] EventDays { get; set; }
    }
}
