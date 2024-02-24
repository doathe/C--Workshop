
IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(), 
    new Robot()
};

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2]
{
    new Worker(),
    new Manager()
};

foreach (var eat in eats)
{
    eat.Eat();
}

// SOLID, Interface Segregation
public interface IWorker
{
    public void Work();
}
public interface IEat
{
    public void Eat();
}
public interface ISalary
{
    public void GetSalary();
}

public class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }
    public void GetSalary()
    {
        throw new NotImplementedException();
    }
    public void Work()
    {
        throw new NotImplementedException();
    }
}
public class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }
    public void GetSalary()
    {
        throw new NotImplementedException();
    }
    public void Work()
    {
        throw new NotImplementedException();
    }
}
public class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}