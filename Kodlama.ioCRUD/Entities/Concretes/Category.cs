using Core.Entities;

namespace Entities.Concretes;

public class Category : BaseEntity <int>
{
    public string Name { get; set; }
}