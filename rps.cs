using System;
class Project
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rock is \"R\", Paper is \"P\", Scissors is \"S\"");
        Console.WriteLine("------------------------------------");
        
        do
        { 
            String userChoice = "";
            String botChoice = "";
            Random random = new Random();
            String[] choices = {"R", "P", "S"};
            bool control = true;
            int c = random.Next(0,3);

            while (control) 
            {
                Console.Write("R/P/S: ");
                userChoice = Console.ReadLine().ToUpper();
                switch (userChoice)
                {
                    case "R":
                        botChoice = choices[c];
                        if (botChoice == "P")
                        {
                            Console.WriteLine("------- Bot Wins -------");
                        }
                        else if (botChoice == "S")
                        {
                            Console.WriteLine("------- User Wins -------");
                        }
                        else
                        {
                            Console.WriteLine("------- Draw -------");
                        }
                        control = false;
                        break;
                    case "P":
                        botChoice = choices[c];
                        if (botChoice == "S")
                        {
                            Console.WriteLine("------- Bot Wins -------");
                        }
                        else if (botChoice == "R")
                        {
                            Console.WriteLine("------- User Wins -------");
                        }
                        else
                        {
                            Console.WriteLine("------- Draw -------");
                        }
                        control = false;
                        break;
                    case "S":
                        botChoice = choices[c];
                        if (botChoice == "R")
                        {
                            Console.WriteLine("------- Bot Wins -------");
                        }
                        else if (botChoice == "P")
                        {
                            Console.WriteLine("------- User Wins -------");
                        }
                        else
                        {
                            Console.WriteLine("------- Draw -------");
                        }
                        control = false;
                        break;
                    default:
                        Console.WriteLine("Only R/P/S.");
                        continue;
                }
                Console.WriteLine($"(User chose: {userChoice})");
                Console.WriteLine($"(Bot chose: {botChoice})");
                Console.WriteLine("-------");
            }
            Console.Write("Go again (y/n)? ");
        } while (Console.ReadLine().ToUpper() == "Y");
    }
}