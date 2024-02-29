using Entities.Concretes;

namespace Business.Abstracts;

public interface ICourseService
{
    public IEnumerable<Course> GetAll();
    public void Add(Course course);
    public Course Get(int id);
    public void Delete(int id);
    public void Update(Course course);
}
