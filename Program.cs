using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double X1, Xn, S, Y;
            const double PI = 3.14;
            const double E = 2.71;
            Console.WriteLine("Insert X1:");
            X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert Xn:");
            Xn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert S:");
            S = Convert.ToDouble(Console.ReadLine());

            for (double i = X1; i <= Xn; i += S)

            {
                Y = (Math.Pow(i, 1 / 5) + Math.Sin(PI * i / 1.7)) / (Math.Sqrt(Math.Cos(i) + 1) * Math.Pow(E, i));
                Console.WriteLine("Y = {0}", Y);
            }
        }
    }
}
