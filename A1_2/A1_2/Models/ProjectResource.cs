namespace A1_2.Models;

public class ProjectResource
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; }
    public int ResourceId { get; set; }
    public Resource Resource { get; set; }
}