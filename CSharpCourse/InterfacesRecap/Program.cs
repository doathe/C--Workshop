// Interface newlenemez, instance alınamaz.
// Interfaceler sadece imza (başlık) içerir.

//IPersonManager customerManager = new CustomerManager();
//customerManager.Add();

//IPersonManager employeeManager = new EmployeeManager();
//employeeManager.Add();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new CustomerManager());
projectManager.Add(new EmployeeManager());
projectManager.Add(new InternManager());

public interface IPersonManager
{
    // unimplemented operation
    public void Add();
    public void Update();
}
public class PersonManager
{
    // implemented operation : İçi doldurulmuş, tamamlanmış operasyon
    public void Add()
    {
        Console.WriteLine("Added");
    }
}
// inherits - class --------------- implements - interface
public class CustomerManager : IPersonManager
{
    public void Add()
    {
        // müşteri ekleme kodları
        Console.WriteLine("Customer added");
    }

    public void Update()
    {
        Console.WriteLine("Customer updated");
    }
}
public class EmployeeManager : IPersonManager
{
    public void Add()
    {
        // personel ekleme kodları
        Console.WriteLine("Employee added");
    }

    public void Update()
    {
        Console.WriteLine("Employee updated");
    }
}
public class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Intern added");
    }

    public void Update()
    {
        Console.WriteLine("Intern updated");
    }
}
public class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}