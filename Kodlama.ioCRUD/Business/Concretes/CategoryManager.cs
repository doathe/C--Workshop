using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(int id)
    {
        _categoryDal.Delete(id);
    }

    public Category Get(int id)
    {
        return _categoryDal.Get(id);
    }

    public IEnumerable<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }
}
