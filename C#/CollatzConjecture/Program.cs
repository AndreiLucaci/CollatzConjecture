using System;
using CollatzConjecture.Engine;

namespace CollatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collatz Conjecture program");

            var engine = new CollatzConjectureEngine();

            while (true)
            {
                Console.Write("Input number: ");
                var numberLn = Console.ReadLine();

                if (numberLn == "q")
                {
                    break;
                }
                if (!ulong.TryParse(numberLn, out var number))
                {
                    Console.WriteLine($"Invalid number: {numberLn}");
                }
                else
                {
                    var steps = engine.Compute(number);

                    Console.WriteLine($"Done in {steps} steps.");
                    Console.WriteLine();
                }
            }
        }
    }
}
