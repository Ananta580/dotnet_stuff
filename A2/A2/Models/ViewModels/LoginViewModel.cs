using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace A2.Models.ViewModels;

public class LoginViewModel
{

    [Required (ErrorMessage = "Email is required")]
    [DisplayName("Email")]
    public string Email { get; set; }
    
    [Required (ErrorMessage = "Password is required")]
    [DisplayName("Password")]
    public string Password { get; set; }
}