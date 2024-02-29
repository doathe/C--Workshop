using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICourseDal
{
    public IEnumerable<Course> GetAll();
    public void Add(Course course);
    public Course Get(int id);
    public void Delete(int id);
    public void Update(Course course);
}
