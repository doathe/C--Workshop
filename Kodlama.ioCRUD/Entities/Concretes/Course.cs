using Core.Entities;

namespace Entities.Concretes;

public class Course : BaseEntity <int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
}
