using System;
class Project
{
    static void Main(string[] args)
    {
        String sts = "y";
        double total = 0;
        double num = 0;
        bool control = true;
        

        do
        {
            try
            {
                Console.Write($"Number to add to total ({total}): ");
                num = Convert.ToDouble(Console.ReadLine());
                
                while (control)
                {
                    Console.Write("+,-,/,*: ");
                    switch (Console.ReadLine())
                    {
                        case "+":
                            total += num;
                            control = false;
                            break;
                        case "-":
                            total -= num;
                            control = false;
                            break;
                        case "/":
                            total = total / num;
                            control = false;
                            break;
                        case "*":
                            total *= num;
                            control = false;
                            break;
                        default:
                            Console.WriteLine("Wrong.");
                            continue;
                    }
                }
            }
            Console.Write("Continue (y/n)? ");
        } while (Console.ReadLine().ToUpper() == "Y");
        Console.WriteLine($"The total is: {total}")
    }
}