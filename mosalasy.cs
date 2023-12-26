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
            int z = 0;
            int n;
            int m;
            int b = 0;


            Console.WriteLine("Hello, Iam Abolfazl naybi.");
            do
            {
                Console.WriteLine("do adad vared konid ta ekhtelafshon ra dar olgo mosalasy bebinid!!");
                x = Convert.ToInt32(Console.ReadLine());
                n = Convert.ToInt32(Console.ReadLine());
            } while (0 > x && 0 > n);

            for (y = x; y >= 1; y--)
            {
                z = z + y;
            }
            for (m = n; m >= 1; m--)
            {
                b = b + m;
            }
            if (z > b)
            {
                Console.Write("ekhtelaf jomle ");
                Console.Write(x);
                Console.Write(" ta ");
                Console.Write(n);
                Console.Write(" = ");
                Console.Write(z - b);
            }
            if (b > z)
            {
                Console.Write("ekhtelaf jomle ");
                Console.Write(x);
                Console.Write(" ta ");
                Console.Write(n);
                Console.Write(" = ");
                Console.Write(b - z);
            }

        }
    }
}