using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Fibonacci_Series
    {
        public static void  FS()
        {

            Console.WriteLine("Enter The Number: ");
            int m=int.Parse(Console.ReadLine());

            int f = 0, s = 1;
            
               
              for(int i=1; i < m; i++)
                {
                    Console.WriteLine(f);
                int next = f + s;
                f = s;
                s = next;
                    

                }
            
        }
    }
}
