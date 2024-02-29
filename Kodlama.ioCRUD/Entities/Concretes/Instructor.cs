using Core.Entities;

namespace Entities.Concretes;

public class Instructor : BaseEntity <int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }

}
