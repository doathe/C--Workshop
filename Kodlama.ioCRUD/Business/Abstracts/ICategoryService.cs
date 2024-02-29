using Entities.Concretes;

namespace Business.Abstracts;

public interface ICategoryService
{
    public IEnumerable<Category> GetAll();
    public void Add(Category category);
    public Category Get(int id);
    public void Delete(int id);
    public void Update(Category category);
}
