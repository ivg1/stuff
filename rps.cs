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
            const String[] choices = {"R", "P", "S"};
            Random random = new Random();
            const int c = random.Next(0,3);

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