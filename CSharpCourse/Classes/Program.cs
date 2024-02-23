using Classes;

CustomerManager customerManager = new CustomerManager();

customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();

productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.City = "Ankara";
customer.Id = 1;
customer.FirstName = "Doğa";
customer.LastName = "Turhan";

Customer customer2 = new Customer 
{ 
    Id = 2,
    FirstName = "Derin",
    LastName = "Demiroğ",
    City = "İstanbul",
};

Console.WriteLine(customer2.FirstName);