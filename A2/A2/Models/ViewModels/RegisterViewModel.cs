using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace A2.Models.ViewModels;

public class RegisterViewModel
{

    [Required(ErrorMessage = "First Name is required.")]
    [MaxLength(50)]
    [DisplayName("First Name")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Last Name is required.")]
    [MaxLength(50)]
    [DisplayName("Last Name")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress]
    [DisplayName("Email")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Password is required.")]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$", 
        ErrorMessage = "Password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character.")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "User role is required.")]
    public string Role { get; set; }
    
    [DisplayName("Date of Birth")]
    public DateTime? DateOfBirth { get; set; }
    [MaxLength(100)]
    public string? Address { get; set; }
}