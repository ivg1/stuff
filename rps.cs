using System;
class Project
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rock is R, Paper is P, Scissors is S");
        Console.WriteLine("------------------------------------");
        
        do
        { 
            String userChoice = "";
            String botChoice = "";
            Random random = new Random();
            String[] choices = {"R", "P", "S"};
            int c = random.Next(0,3);

            while (true) 
            {
                Console.Write("R/P/S: ");
                switch (Console.ReadLine().ToUpper())
                {
                    case "R":
                        botChoice = choices[c];
                        break;
                    case "P":
                        botChoice = choices[c];
                        break;
                    case "S":
                        botChoice = choices[c];
                        break;
                    default:
                        Console.WriteLine("Only R/P/S.");
                        continue;
                }
            }
        } while (true);
    }
}