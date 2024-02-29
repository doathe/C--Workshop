using Entities.Concretes;

namespace Business.Abstracts;

public interface IInstructorService
{
    public IEnumerable<Instructor> GetAll();
    public void Add(Instructor instructor);
    public Instructor Get(int id);
    public void Delete(int id);
    public void Update(Instructor instructor);
}
