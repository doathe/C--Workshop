using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    public List<Category> _categories;

    public CategoryDal()
    {
        _categories = new List<Category>();
        _categories.Add(new Category() { Id = 1, Name = "Programlama", CreatedDate = DateTime.Now});
    }

    public void Add(Category category)
    {
        category.Id = _categories.Count + 1;
        category.CreatedDate = DateTime.Now;
        _categories.Add(category);
    }

    public void Delete(int id)
    {
        var existingItem = _categories.FirstOrDefault(c => c.Id == id);
        if(existingItem != null)
        {
            _categories.Remove(existingItem);
        }
    }

    public Category Get(int id)
    {
        var existingItem = _categories.FirstOrDefault(c => c.Id == id);
        if(existingItem != null)
        {
            return existingItem;
        }
        else 
            throw new ArgumentNullException();
    }

    public IEnumerable<Category> GetAll()
    {
        return _categories;
    }

    public void Update(Category category)
    {
        var existingItem = Get(category.Id);
        existingItem.Name = category.Name;
        existingItem.UpdatedDate = DateTime.Now;
    }
}