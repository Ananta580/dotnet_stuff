using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace A1_2.ViewModel;

public class ProjectViewModel
{
    public int Id { get; set; }
    [DisplayName("Project Name")]
    [Required(ErrorMessage = "Project Name is required")]
    [StringLength(100, ErrorMessage = "Project Name cannot be longer than 100 characters")]
    public string Name { get; set; }

    [DisplayName("Project Description")]
    [Required(ErrorMessage = "Description is required")]
    [MinLength(20, ErrorMessage = "Project Description cannot be shorter than 50 characters")]
    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    public string Description { get; set; }

    [DisplayName("Start Date")]
    [Required(ErrorMessage = "Start Date is required")]
    [DataType(DataType.Date, ErrorMessage = "Please enter a valid date")]
    public DateTime StartDate { get; set; }

    [DisplayName("End Date")]
    [Required(ErrorMessage = "End Date is required")]
    [DataType(DataType.Date, ErrorMessage = "Please enter a valid date")]
    public DateTime EndDate { get; set; }

    [DisplayName("Resources")]
    [Required(ErrorMessage = "At least one Resource must be selected.")]
    public List<int> ResourcesId { get; set; } = null;

}