using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    public List<Instructor> _instructors;

    public InstructorDal()
    {
        _instructors = new List<Instructor>();
        _instructors.Add(new Instructor() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", CreatedDate = DateTime.Now, Description = "Instructor"});
        _instructors.Add(new Instructor() { Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı", CreatedDate = DateTime.Now, Description = "Instructor" });
    }

    public void Add(Instructor instructor)
    {
        instructor.Id = _instructors.Count + 1;
        instructor.CreatedDate = DateTime.Now;
        _instructors.Add(instructor);
    }

    public void Delete(int id)
    {
        var existingItem = _instructors.FirstOrDefault(x => x.Id == id);
        if (existingItem != null)
        {
            _instructors.Remove(existingItem);
        }
    }

    public Instructor Get(int id)
    {
        var existingItem = _instructors.FirstOrDefault(c => c.Id == id);
        if (existingItem != null)
        {
            return existingItem;
        }
        else
            throw new ArgumentNullException();
    }

    public IEnumerable<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor instructor)
    {
        var existingItem = Get(instructor.Id);
        existingItem.FirstName = instructor.FirstName;
        existingItem.LastName = instructor.LastName;
        existingItem.Description = instructor.Description;
        existingItem.UpdatedDate = DateTime.Now;
    }
}
