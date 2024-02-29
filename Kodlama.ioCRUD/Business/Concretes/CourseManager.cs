using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(int id)
    {
        _courseDal.Delete(id);
    }

    public Course Get(int id)
    {
        return _courseDal.Get(id);
    }

    public IEnumerable<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}