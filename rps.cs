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
            int c = random.Next(0,choices.Length);
        } while (true);
    }
}