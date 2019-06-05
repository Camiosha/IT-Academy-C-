using System;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {

            short x = 8, y = 5;
            Console.WriteLine("x=8, y=5");
            
            if (x == y)
                Console.WriteLine("x == y true");
            else Console.WriteLine("x == y false");

            if (x != y)
                Console.WriteLine("x != y true");
            else Console.WriteLine("x != y false");

            if (x > y)
                Console.WriteLine("x > y true");
            else Console.WriteLine("x > y false");

            if (x < y)
                Console.WriteLine("x < y true");
            else Console.WriteLine("x < y false");

            if (x >= y)
                Console.WriteLine("x >= y true");
            else Console.WriteLine("x >= y false");

            if (x <= y)
                Console.WriteLine("x <= y true");
            else Console.WriteLine("x <= y false");
        }
    }
}
