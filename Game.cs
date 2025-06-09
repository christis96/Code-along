namespace Code_along;

public class Game
{
    Cashier cashier = new Cashier("John");

    private List<Customer> customers = new List<Customer>
    {
        new Customer("Paul", 26, 21, 12),
        new Customer("Steven", 16, 20, 00),
        new Customer("Pete", 30, 30, 14),
        new Customer("Fiona", 19, 17, 20)
    };

    public void Run()
    {
        foreach (Customer customer in customers)
        {
            customer.Interactwithcashier(cashier, customer);
        }
        
    }
}