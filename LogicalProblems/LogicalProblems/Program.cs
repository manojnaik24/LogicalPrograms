using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Problem Number: " + "1. Fibonacci Series" + "2. Perfect Number");
            int n=int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:

                    Fibonacci_Series.FS();
                    Console.ReadLine();
                    break;
                case 2:

                    Perfect_Number.PNumber();
                    break;


            }
        }
    }
}
