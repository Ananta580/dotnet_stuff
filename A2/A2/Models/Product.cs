using System.ComponentModel;

namespace A2.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    [DisplayName("Short Description")]
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    [DisplayName("Featured")]
    public bool IsFeatured { get; set; }
    public decimal Price { get; set; }
    public string? Image { get; set; }
    
}