namespace Interfaces;
// 
public interface ICustomerDal
{
    public void Add();
    public void Update();
    public void Delete();
}
public class SqlServerCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Sql added");
    }

    public void Delete()
    {
        Console.WriteLine("Sql deleted");
    }

    public void Update()
    {
        Console.WriteLine("Sql updated");
    }
}
public class OracleServerCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Oracle added");
    }

    public void Delete()
    {
        Console.WriteLine("Oracle deleted");
    }

    public void Update()
    {
        Console.WriteLine("Oracle updated");
    }
}

public class CustomerManager
{
    public void Add(ICustomerDal customerDal)
    {
        customerDal.Add();
    }
}
