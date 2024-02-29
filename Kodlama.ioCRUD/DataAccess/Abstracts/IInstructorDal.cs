using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IInstructorDal
{
    public IEnumerable<Instructor> GetAll();
    public void Add(Instructor instructor);
    public Instructor Get(int id);
    public void Delete(int id);
    public void Update(Instructor instructor);
}
