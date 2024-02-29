using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    public List<Course> _courses;

    public CourseDal()
    {
        _courses = new List<Course>();
        _courses.Add(new Course() { Id = 1, CategoryId = 1, InstructorId = 1, Name = "C# Geliştirici 2022", Price = 0.0, Description = "C# Course", CreatedDate = DateTime.Now});
        _courses.Add(new Course() { Id = 2, CategoryId = 1, InstructorId = 1, Name = "C# Geliştirici 2023", Price = 0.0, Description = "C# Course", CreatedDate = DateTime.Now });
        _courses.Add(new Course() { Id = 3, CategoryId = 1, InstructorId = 2, Name = "Java", Price = 0.0, Description = "Java Course", CreatedDate = DateTime.Now });
    }

    public void Add(Course course)
    {
        course.Id = _courses.Count + 1;
        course.CreatedDate = DateTime.Now;
        _courses.Add(course);
    }

    public void Delete(int id)
    {
        var existingItem = _courses.FirstOrDefault(c => c.Id == id);
        if (existingItem != null)
        {
            _courses.Remove(existingItem);
        }
    }

    public Course Get(int id)
    {
        var existingItem = _courses.FirstOrDefault(c => c.Id == id);
        if (existingItem != null)
        {
            return existingItem;
        }
        else
            throw new ArgumentNullException();
    }

    public IEnumerable<Course> GetAll()
    {
        return _courses;
    }

    public void Update(Course course)
    {
        var existingItem = Get(course.Id);
        existingItem.Name = course.Name;
        existingItem.CategoryId = course.CategoryId;
        existingItem.InstructorId = course.InstructorId;
        existingItem.Price = course.Price;
        existingItem.Description = course.Description;
        existingItem.UpdatedDate = DateTime.Now;
    }
}
