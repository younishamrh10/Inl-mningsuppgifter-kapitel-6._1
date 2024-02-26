using System;

namespace Inlämningsuppgifterkapitel6._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(plusa(3, 8, 9));
        }

        static int plusa(int tal1, int tal2, int tal3)
        {
            int sum = tal1 + tal2 + tal3;
            return sum;
        }

    }
}