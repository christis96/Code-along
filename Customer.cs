namespace Code_along;

public class Customer
{
    public string Name;
    public int LooklikeAge;
    public int RealAge;
    public int Time;
    public int Beers;

    public Customer(string name, int looklikeAge, int realAge, int time)
    {
        Name = name;
        LooklikeAge = looklikeAge;
        RealAge = realAge;
        Time = time;
    }

    public void Interactwithcashier(Cashier cashier, Customer customer)
    {
        Console.WriteLine($"Hi {Name}, what would you like to do?");
        Console.WriteLine("1. Buy beer 2. Run away");


        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine($"{Name} is trying to buy a beer.");
                cashier.Makesaledecision(customer);
                break;

            case "2":
                Console.WriteLine($"{Name} ran away.");
                break;

            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }
}