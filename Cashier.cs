namespace Code_along;

public class Cashier
{
    public string Name;
    public Cashier(string name)
    { 
        Name = name;
    }
    public bool Checkifcustomerisofage(Customer customer)
    {
        
        Console.WriteLine($"Cheking if {customer.Name} looks 25 or older...");

        if (customer.LooklikeAge >= 25)
        {
            Console.WriteLine("Customer looks old enough.");
            return true;
        }

        if (customer.RealAge >= 18)
        {
            Console.WriteLine($"ID shows that {customer.Name} is old enough.");
            return true;
        }

        Console.WriteLine("Customer is too young.");
        return false;
    }

    public void Makesaledecision(Customer customer)
    {
        
        Checkifcustomerisofage(customer);
        
       
        if (customer.Time < 10 || customer.Time > 20)
        {
            Console.WriteLine($"The time is {customer.Time}, and it's illegal to sell at this time.");
        }
        Console.WriteLine($"{Name}, Do you want to sell?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine($"{Name} Selling beer to {customer.Name}.");
                break;

            case "2":
                Console.WriteLine($"{Name} is denying {customer.Name} to buy beer.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

    }
}