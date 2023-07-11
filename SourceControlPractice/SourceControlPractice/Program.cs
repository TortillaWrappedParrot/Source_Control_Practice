using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
                    line = Console.ReadLine();
                    result = int.TryParse(line, out _);
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
                            num1Input = Console.ReadLine();
                            num1Check = int.TryParse(num1Input, out _);
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
                            num2Input = Console.ReadLine();
                            num2Check = int.TryParse(num2Input, out _);
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
                                if (num1 != 0 && num2 != 0)
                                {
                                    Console.WriteLine(num1 / num2);
                                } else
                                {
                                    Console.WriteLine("Attempted division by zero");
                                }
                                
                                break;
                        }
                        Console.WriteLine("-------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Enter your untrimmed line");
                        Console.WriteLine(Console.ReadLine().Trim());
                        Console.WriteLine("-------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Enter your line with whitespaces");
                        string unFixedLine = Console.ReadLine();
                        string fixedLine = new string(unFixedLine.ToCharArray()
                        .Where(c => !Char.IsWhiteSpace(c))
                        .ToArray());
                        Console.WriteLine(fixedLine);
                        Console.WriteLine("-------------------------------");
                        break;
                    case 4:
                        Random rnd = new Random();
                        int trys = 0;
                        int num = rnd.Next(1, 100);
                        Console.WriteLine("I've picked a number between 1-100.");
                        int guess = 0;
                        Console.WriteLine(num);
                        while (guess != num)
                        {
                            Console.WriteLine("Enter your guess");
                            string stringGuess = Console.ReadLine();
                            while (int.TryParse(stringGuess, out _) == false)
                            {
                                Console.WriteLine("That's not a valid number!");
                                stringGuess = Console.ReadLine();
                            }
                            guess = int.Parse(stringGuess);
                            if (guess < num)
                            {
                                Console.WriteLine("Your guess is too low!");
                            } else
                            {
                                if (guess != num)
                                {
                                    Console.WriteLine("Your guess is too high!");
                                }
                            }
                            trys++;
                        }
                        Console.WriteLine("You got it!, my number was " + num + " and you got it in " + trys + " tries!");
                        Console.WriteLine("-------------------------------");
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("-------------------------------");
                        break;
                }
            }
        }
    }
}
