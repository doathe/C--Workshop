
using Interfaces;

PersonManager personManager = new PersonManager();
personManager.Add(new Customer { Id = 1, FirstName = "Doğa", LastName = "Turhan", Address = "İstanbul" });

Student student = new Student
{
    Id = 1,
    FirstName = "Derin",
    LastName = "Demiroğ",
    Department = "Computer Science"
};

personManager.Add(student);

IPerson person = new Customer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new SqlServerCustomerDal());

// Interfaceler instance alınamaz (newlenemez)
public interface IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
public class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}
public class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
}
public class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
}
class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName + " " + person.LastName);
    }
}