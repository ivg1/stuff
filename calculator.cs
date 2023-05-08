// c# calculator (x+y=z)
using System;
class Project
{
	static void Main(string[] args)
	{
	    Console.WriteLine("Calculator");
	    Console.WriteLine("----------");
	    do
	    {
			double num1 = 0;
			double num2 = 0;
			double result = 0;
			String ops = "";
			while (true)
			{
				try
				{
					Console.Write("First number: ");
					num1 = Convert.ToDouble(Console.ReadLine());
					Console.Write("Second number: ");
					num2 = Convert.ToDouble(Console.ReadLine());
					while (ops != "+" && ops != "-" && ops != "*" && ops != "/")
					{
					    Console.Write("Operator (+,-,*,/): ");
					    ops = Console.ReadLine();
					    switch (ops)
					    {
					        case "+":
					            result = num1+num2;
					            Console.WriteLine($"{num1} + {num2} = {result}");
					            break;
					        case "-":
					            result = num1-num2;
					            Console.WriteLine($"{num1} - {num2} = {result}");
					            break;
					        case "*":
					            result = num1*num2;
					            Console.WriteLine($"{num1} * {num2} = {result}");
					            break;
					        case "/":
					            result = num1/num2;
					            Console.WriteLine($"{num1} / {num2} = {result}");
					            break;
					        default:
					            Console.WriteLine("Error in operator");
					            break;
					    }
					}
					break;
				}
				catch (FormatException e)
				{
					Console.WriteLine("Enter ONLY numbers");
				}
				catch (Exception e)
				{
					Console.WriteLine("Something went wrong.");
				}
			}
			Console.Write("Go again? (Y = yes, N = no): ");
	    } while (Console.ReadLine().ToUpper() == "Y");
	}
}
