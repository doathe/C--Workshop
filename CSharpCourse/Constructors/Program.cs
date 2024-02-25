// Constructor(yapıcı blok), bir classı newlediğimiz zaman çalışır. Bir class ilk kez oluştuğu zaman constructor bir kere çalışır ve bir daha çalışmaz.

Customer customer1 = new Customer { Id = 1, FirstName = "Doğa", LastName = "Turhan", City = "İstanbul" };

Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

Console.WriteLine(customer2.FirstName);

public class Customer
{
    // ctor -> constructor kısa yol
    // Yazmazsak arkada default constructor çalışır.
    public Customer()
    {
        
    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;

        Console.WriteLine("Yapıcı blok çalıştı");
    }
    // prop -> properties kısa yol
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}