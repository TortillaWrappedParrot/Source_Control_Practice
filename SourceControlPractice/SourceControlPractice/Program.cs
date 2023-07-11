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
                bool result = int.TryParse(Console.ReadLine(),out _);
                while (result == false)
                {
                    Console.WriteLine("Please enter a valid number");
                    result = int.TryParse(Console.ReadLine(), out _);
                }

                switch (assignment)
                {
                    case 1:
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
