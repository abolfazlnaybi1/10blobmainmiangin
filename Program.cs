

namespace Rextester
{ 


    public class Program
    { 
    

        public static void Main(string[] args)
        { 
         //I'm Abolfazl naybi

            double a;
            double b;
            double c;
            double d;
            double e;
            double f;
            double g;
            double h;
            double i;
            double j;
            double o;
            Console.WriteLine("Hello!");

            do
            {
                Console.WriteLine("nomre Pishrafte1 ?");
                a = Convert.ToDouble(Console.ReadLine());
            } while (a > 20 && a < 0);
            do
            {
                Console.WriteLine("nomre Tafsir ?");
                b = Convert.ToDouble(Console.ReadLine());
            } while (b > 20 && b < 0);
            do
            {
                Console.WriteLine("nomre Riazi ?");
                c = Convert.ToDouble(Console.ReadLine());
            } while (c > 20 && c < 0);
            do
            {
                Console.WriteLine("nomre Kargah ?");
                d = Convert.ToDouble(Console.ReadLine());
            } while (d > 20 && d < 0);
            do
            {
                Console.WriteLine("nomre Engelisi ?");
                e = Convert.ToDouble(Console.ReadLine());
            } while (e > 20 && e < 0);
            do
            {
                Console.WriteLine("nomre Pishrafte2 ?");
                f = Convert.ToDouble(Console.ReadLine());
            } while (f > 20 && f < 0);
            do
            {
                Console.WriteLine("nomre Sheygraiy ?");
                g = Convert.ToDouble(Console.ReadLine());
            } while (g > 20 && g < 0);
            do
            {
                Console.WriteLine("nomre Varzesh ?");
                h = Convert.ToDouble(Console.ReadLine());
            } while (h > 20 && h < 0);

            do
            {
                Console.WriteLine("nomre Sistem Amel ?");
                i = Convert.ToDouble(Console.ReadLine());
            } while (i > 20 && i < 0);
            do
            {
                Console.WriteLine("nomre Algoritm ?");
                j = Convert.ToDouble(Console.ReadLine());
            } while (j > 20 && j < 0);
            o = (a + b * 3 + c * 2 + d + e * 2 + f * 3 + g * 2 + h * 2 + i + j * 3) / 20;
            Console.WriteLine(" miangin = ");
            Console.WriteLine(o);
        }

    }

}
