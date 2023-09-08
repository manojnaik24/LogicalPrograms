using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Prime_Number
    {
        public static void PN()
        {
            Console.WriteLine("Enter the no:");
            int n = int.Parse(Console.ReadLine());

            if (n == 0 || n == 1)
            {
                Console.WriteLine("Not a Prime Number");

            }

            if (n % 2 == 0)
            {

                Console.WriteLine("Not a Prime Number");

            }
            else if (n % 2 != 0)
            {


                Console.WriteLine("is a prime number");
            }


            Console.ReadLine();

        }
    }
}
