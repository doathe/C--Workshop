using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

// Interface; belirli method imzalarını barındırırlar ve birbirinin alternetifi olan sistemlerin farklı implementasyon yapmalarını sağlarlar. (yabancı uyruklu farklı, vatandaş farklı)
// Interfaceler newlenemez, referans tutarlar.
public interface IApplicantService
{
    public void ApplyForMask(Person person);
    public List<Person> GetList();
    public bool CheckPerson(Person person);
}
