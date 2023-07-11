using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sentinel = 0;
            int assignment = 0;
            while (sentinel != 5) {
                Console.WriteLine("Please enter the number for the program you need");
                Console.WriteLine("1 - Basic Calculator");
                Console.WriteLine("2 - Line Trimmer");
                Console.WriteLine("3 - Whitespace Remover");
                Console.WriteLine("4 - Guessing Game");
                Console.WriteLine("5 - Exit");
                Console.Write("Enter your number: ");
                string line = Console.ReadLine();
                bool result = int.TryParse(line,out _);
                while (result == false && result != true)
                {
                    Console.WriteLine("Please enter a valid number");
                    result = int.TryParse(Console.ReadLine(), out _);
                }
                assignment = int.Parse(line);
                switch (assignment)
                {
                    case 1:
                        Console.WriteLine("Enter the first int");
                        string num1Input = Console.ReadLine();
                        bool num1Check = int.TryParse(num1Input, out _);
                        while (num1Check == false)
                        {
                            Console.WriteLine("Please enter a valid int");
                            num1Check = int.TryParse(Console.ReadLine(), out _);
                        }
                        Console.WriteLine("Enter your comparetor");
                        string compareterInput = Console.ReadLine().Trim();
                        while (compareterInput != "/" && compareterInput != "*" && compareterInput != "+" && compareterInput != "-")
                        {
                            Console.WriteLine("Please enter a valid comparter");
                            compareterInput = Console.ReadLine().Trim();
                        }
                        Console.WriteLine("Enter the second int");
                        string num2Input = Console.ReadLine();
                        bool num2Check = int.TryParse(num2Input, out _);
                        while (num2Check == false)
                        {
                            Console.WriteLine("Please enter a valid int");
                            num2Check = int.TryParse(Console.ReadLine(), out _);
                        }
                        int num1 = int.Parse(num1Input);
                        int num2 = int.Parse(num2Input);
                        switch (compareterInput)
                        {
                            case "*":
                                Console.WriteLine(num1 * num2);
                                break;
                            case "+":
                                Console.WriteLine(num1 + num2);
                                break;
                            case "-":
                                Console.WriteLine(num1 - num2);
                                break;
                            case "/":
                                Console.WriteLine(num1 / num2);
                                break;
                        }
                        Console.WriteLine("-------------------------------");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
