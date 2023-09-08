using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Reverse_a_number
    {
        public static void RN()
        {
            Console.WriteLine("Enter The Number");
            int a =int.Parse( Console.ReadLine());
            int rev = 0;
            while (a != 0)
            {
                int b = a % 10;
                rev = rev * 10 + b;
                a = a / 10;
            }
            Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
}
