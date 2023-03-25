using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			do
			{
				double num1, num2, result;
				num1 = num2 = result = 0.0;

				Console.Write("Please enter the First number: ");
				num1 = Convert.ToDouble(Console.ReadLine());

				Console.Write("Now, enter the second number: ");
				num2 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Select an option for operation:");
			casePrompt:
				Console.WriteLine("\t+ : Add\n\t- : Substract \n\t* : Multiply \n\t/ : Divide");
				Console.Write("Your input : ");

				switch (Console.ReadLine())
				{
					case "+":
						result = num1 + num2;
						Console.WriteLine($"Result of addition is : {num1} + {num2} = {result}");
						break;

					case "-":
						result = num1 - num2;
						Console.WriteLine($"Result of substraction is : {num1} - {num2} = {result}");
						break;

					case "*":
						result = num1 * num2;
						Console.WriteLine($"Result of multiplication is : {num1} * {num2} = {result}");
						break;

					case "/":
						result = num1 / num2;
						Console.WriteLine($"Result of division is : {num1} / {num2} = {result}");
						break;
					default:
						Console.WriteLine("You selected a wrong option.\nPlease Try again!\nSelect a valid input from given options:");
						goto casePrompt;
				}
				Console.WriteLine("Would you like to continue?\nPlease press 'Y' to continue and 'N' to quit.");
			}
			while (Console.ReadLine().ToUpper() == "Y");
			Console.WriteLine("See you later!");
		}
	}
}
