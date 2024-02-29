using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICategoryDal
{
    public IEnumerable<Category> GetAll();
    public void Add(Category category);
    public Category Get(int id);
    public void Delete(int id);
    public void Update(Category category);
}