using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager
{
    // dependency injection
    private IApplicantService _applicantService;

    // Constructor -> new yapıldığında çalışır.
    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }

    public void GiveMask(Person person)
    {
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine(person.FirstName + " için maske verildi.");
        }
    }
}
