/*
    - The Simple & Compound methods need to be finished.
    - Some random things to add.
    - Yeah.
*/

using System;
class Project
{
    static void Main(string[] args)
    {
        Console.WriteLine("Interest calculator.");
        Console.WriteLine("--------------------");
        while (true)
        {
            string choice = "";
            Console.WriteLine("So uhh... the Compound Interest thing kinda broken so pls pls pls pls pls dont try using it and use the Simple Interest one instead\n");
            Console.Write("Simple/Compound Interest (S/C)? ");
            choice = Console.ReadLine().ToUpper();
            switch (choice)
            {
                case "S":
                    Simple();
                    break;
                case "C":
                    Compound();
                    break;
                default:
                    Console.WriteLine("S or C.");
                    continue;
            }
        }
    }
    static void Simple()
    {
        Console.WriteLine("You chose 'Simple interest'.\n");
        do
        {
            try
            {
                double deposit = 0;
                double interest = 0;
                double years = 0;
                double end = 0;

                double r = 0, brackets = 0;

                Console.Write("How much did you deposit (number)? ");
                deposit = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("What is the interest (without %)? ");
                interest = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("In how may years to see (number)? ");
                years = Convert.ToDouble(Console.ReadLine());

                r = interest/100;
                brackets = r*years + 1;
                end = deposit * brackets;

                Console.WriteLine($"-------- The total is ${end}\n");

            }
            catch (FormatException e)
            {
                Console.WriteLine("Only Numbers.");
                continue;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
                continue;
            }
        } while (true);
    }

    //This crap doesnt work so dont try it but try to fix it :)
    static void Compound()
    {
        Console.WriteLine("You chose 'Compound interest'.\n");
        do
        {
            try
            {
                double deposit = 0;
                double interest = 0;
                double years = 0;
                double end = 0;

                double r = 0, brackets = 0, control = 0;

                Console.Write("How much did you deposit (number)? ");
                deposit = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("What is the interest (without %)? ");
                interest = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("In how may years to see (number)? ");
                years = Convert.ToDouble(Console.ReadLine());

                control = years;
                r = interest/100;
                brackets = r + 1;
                for (int i = 0; i<years; i++)
                {
                    end = deposit*brackets;
                    deposit = end;
                }

                Console.WriteLine($"-------- The total is ${end}\n");

            }
            catch (FormatException e)
            {
                Console.WriteLine("Only Numbers.");
                continue;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
                continue;
            }
        } while (true);
    }
}
