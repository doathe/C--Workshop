namespace Classes;

public class Customer
{


    //// Encapsulation
    //private string _firstName;
    //public string FirstName { 
    //    get{ return "Mr. " + _firstName; }
    //    set { _firstName = value; }
    //}

    // Property
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

    // Field
    public string Region;
}