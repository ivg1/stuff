using System;
class Project
{
    static void Main(string[] args)
    {
        Card info = new Card();
        Console.WriteLine("Atm legit from tinkoff");
        Console.WriteLine("----------------------");

        while (true)
        {
            Console.Write("Please enter your CVV: ");
            if (Console.ReadLine() == info.Cvv)
            {
                Console.WriteLine("Welcome "+info.Fname+".\n");
                break;
            }
            else 
            {
                Console.WriteLine("Wrong CVV.");
            }
        }
        while (true)
        {
            Console.WriteLine("Your balance is: $"+info.Balance);
            Console.WriteLine(@"Options:
    1) Invest
    2) Send Money
    3) Earn Money
    4) Transactions History");
            while (true)
            {
                Console.Write("     Choose an option (number): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("----------");
                        Invest();
                        break;
                    case "2":
                        Console.WriteLine("----------");
                        Send();
                        break;
                    case "3":
                        Console.WriteLine("----------");
                        Earn();
                        break;
                    case "4":
                        Console.WriteLine("----------");
                        History();
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        continue;
                }
            }
        }
    }


    static void Invest()
    {
        
    }
    static void Send()
    {

    }
    static void Earn()
    {

    }
    static void History()
    {

    }
}
public class Card
{
    public string Fname = "John";
    public string Sname = "Doe";
    public string cardNum = "123-456-7890";
    public string Cvv = "364";
    public string Pin = "1234";
    public double Balance = 1000;
}
