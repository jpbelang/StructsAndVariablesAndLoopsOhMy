using System;
using System.Collections.Generic;

namespace Variables
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Regle generale  BAD: on declare les variables proche de leur utilisation
            int i;

            // code ici....
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("i = " + i);
            }

            Console.WriteLine("sum: " + sum(1, 3));
        }

        public static int sum(int from, int to)
        {
            int sum = 0;
            for (int i = from; i <= to; i++)
            {
                sum = sum + i;
            }

            return sum;
        }
    }
}