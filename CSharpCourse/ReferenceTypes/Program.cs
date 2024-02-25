// Reference Types -> array, class, interface... (Heap, bellekte) (Stack'te adres tutar)
// Value Types -> int, decimal, float, enum, boolean (Stack, bellekte)
// Kullanılmayan veriyi Garbage Collector bellekten temizler

// Value Types Example
int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2;
sayi2 = 100;

Console.WriteLine("Sayı 1 = " + sayi1);

// Reference Types Example
int[] sayilar1 = new int[] { 1, 2, 3 };
int[] sayilar2 = new int[] { 10, 20, 30 };

sayilar1 = sayilar2;
sayilar2[0] = 1000;

Console.WriteLine("Sayilar1[0] = " + sayilar1[0]);

// Class Example

Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Engin";
person2 = person1;
person1.FirstName = "Doğa";

Console.WriteLine("Person2's FirstName = " + person2.FirstName);

Customer customer = new Customer();
customer.FirstName = "Salih";
customer.CreditCardNumber = "1234567890";

Employee employee = new Employee();
employee.FirstName = "Doğa";

Person person3 = customer;
customer.FirstName = "Ahmet";

Console.WriteLine("Person3's FirstName = " + person3.FirstName);
// boxing
Console.WriteLine(((Customer)person3).CreditCardNumber);

PersonManager personManager = new PersonManager();
personManager.Add(customer);
personManager.Add(employee);


public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
// base class : Person (parent)
public class Customer : Person
{
    public string CreditCardNumber { get; set; }
}
public class Employee : Person
{
    public int EmployeeNumber { get; set; }
}
public class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName + " added.");
    }
}