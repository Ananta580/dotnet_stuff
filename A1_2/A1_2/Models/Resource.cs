using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace A1_2.Models;

public class Resource
{
    public int Id { get; set; }
    
    [DisplayName("Resource Name")]
    [Required(ErrorMessage = "Resource Name is required")]
    [StringLength(100, ErrorMessage = "Resource Name cannot be longer than 100 characters")]
    [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Resource Name can only contain letters, numbers, and spaces")]
    public string Name { get; set; }

    [DisplayName("Resource Type")]
    [Required(ErrorMessage = "Resource Type is required")]
    [StringLength(50, ErrorMessage = "Resource Type cannot exceed 50 characters")]
    public string Type { get; set; }

    [DisplayName("Unit of Measurement")]
    [Required(ErrorMessage = "Unit is required")]
    [StringLength(20, ErrorMessage = "Unit cannot exceed 20 characters")]
    [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Unit can only contain letters and spaces")]
    public string Unit { get; set; }

    [DisplayName("Availability")]
    public bool IsAvailable { get; set; }
}