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
            int w;
            double y;
            double z;

            Console.WriteLine("Hello, Iam Abolfazl naybi.");
            do
            {
                Console.WriteLine("yek adad vared konid to javabash ra dar algo fibonatchy bebini !");

                x = Convert.ToInt32(Console.ReadLine());
            } while (x < 0);

            if (x <= 1)
            {
                Console.Write("jomle ");
                Console.Write(x);
                Console.Write(" donbale fibonatchy = 1");
            }
            if (x >= 2)
            {
                y = Math.Pow(1.61803398875, x);
                z = Math.Pow(0.61803398875, x);
                w = Convert.ToInt32((y - z) / 2.2360679775);


                Console.Write("jomle ");
                Console.Write(x);
                Console.Write(" donbale fibonatchy = ");
                Console.Write(w);
            }



        }
    }
}