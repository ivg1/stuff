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
    3) Earn Money");
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
                    default:
                        Console.WriteLine("Invalid Option.");
                        continue;
                }
            }
        }
    }


    static void Invest()
    {
        Card info = new Card();
        Console.WriteLine("You chose Investing.\n");
        while (true)
        {
            try
            {
                Console.WriteLine("How much do you want to invest? ");
                info.Invested = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"You invested ${info.Invested}");
                
            }
            catch (FormatException e)
            {
                Console.WriteLine("Numbers, not words you monkey.");
            }
        }
    }
    static void Send()
    {
        Card info = new Card();
        Console.WriteLine("You chose Investing.\n");
        Console.WriteLine("Info: Here you can send money to other people.")
        while (true)
        {
            
        }
    }
    static void Earn()
    {
        Card info = new Card();
        Console.WriteLine("You chose Earning.\n");
        Console.WriteLine("Info: Here you can earn money by doing stuff (which?)");
        while (true)
        {
            
        }
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

    public double Invested = 0;
    public double Sent = 0;
    public double Earned = 0;
}
