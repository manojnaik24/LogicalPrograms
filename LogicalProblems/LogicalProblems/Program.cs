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
            Console.WriteLine("Enter the Problem Number: " + "1.Fibonacci Series" +   "   2.Perfect Number"   +  "   3.Prime Number"+"Reverse a Number");
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


                case 3:
                    Prime_Number.PN();
                    break;

                case 4:
                    Reverse_a_number.RN();
                    break;

            }
        }
    }
}
