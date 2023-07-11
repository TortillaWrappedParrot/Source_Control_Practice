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
                bool result = int.TryParse(Console.ReadLine(),out _);

                switch (sentinel)
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
