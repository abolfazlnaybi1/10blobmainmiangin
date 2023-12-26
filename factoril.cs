using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions; 

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)  
        {
            int x;
            int y;
            int z = 1;


            Console.WriteLine("Hello, Iam Abolfazl naybi.");    
            do
            {
                Console.WriteLine("yek adad varedkon ta fakturielash ra bebini!");
                x = Convert.ToInt32(Console.ReadLine());

            } while (0 >= x);

            for (y = x; y >= 1; y--)
            {
                z = z * y;
            }
            Console.Write(x);
            Console.Write(" factoril = ");
            Console.Write(z);
        }
    }
}