
Customer customer = new Customer();
Person[] persons = new Person[3]
{
    new Customer{FirstName = "Doğa"},
    new Student{FirstName = "Engin"},
    new Person{FirstName = "Derin"}
};

foreach (Person person in persons)
{
    Console.WriteLine(person.FirstName);
}

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
// Yalnızca 1 Class inherit alınabilir, ancak birden fazla Interface inherit alınabilir.
// Classların tek başına bir anlamı vardır ancak Interfacelerin(Implementasyondur) tek başına bir anlamı yoktur.
// 
public class Customer : Person
{
    public string City { get; set; }
}
public class Student : Person
{
    public string Department { get; set; }
}