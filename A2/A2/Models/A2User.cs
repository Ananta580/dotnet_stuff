using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace A2.Models;

public class A2User: IdentityUser
{
    [MaxLength(50)]
    public string? FirstName { get; set; }
    [MaxLength(50)]
    public string? LastName { get; set; }
    [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }
    [MaxLength(100)]
    public string? Address { get; set; }
}