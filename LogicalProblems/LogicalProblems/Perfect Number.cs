﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public  class Perfect_Number
    {
        public static void PNumber() {

            Console.WriteLine("Enter The Number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1;i<n; i++)
            {
                if (n %i  == 0)
                {
                    Console.WriteLine(i);
                   
                }
            }
            Console.ReadLine() ;
        }
    }
}
