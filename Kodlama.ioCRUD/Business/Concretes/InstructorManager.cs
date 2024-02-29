using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }
    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Delete(int id)
    {
        _instructorDal.Delete(id);
    }

    public Instructor Get(int id)
    {
        return _instructorDal.Get(id);
    }

    public IEnumerable<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }
}
