using System;
using System.Collections.Generic;

namespace Statements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name = args[0];
            if (name == "hello")
            {
                Console.WriteLine("Bonjour");
            }

            for (int i = 0; i < args.Length; i++)
            {
                // Quel est le type d'"argument" ?
                var argument = args[i];
                Console.WriteLine(argument);
            }
        }
    }
}