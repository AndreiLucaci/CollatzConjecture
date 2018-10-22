using System;

namespace CollatzConjecture.Engine
{
    public class CollatzConjectureEngine : ICollatzConjectureEngine
    {
        public ulong Compute(ulong number)
        {
            return Compute(number, 1);
        }

        private ulong Compute(ulong number, ulong step)
        {
            while (true)
            {
                if (number == 1)
                {
                    return step;
                }

                var isEven = number % 2 == 0;
                var intermediary =  isEven ? number : 3 * number + 1;
                var next = intermediary / 2;

                Console.WriteLine($"[{step}]: {number} => {intermediary} => {next}");

                number = next;
                step = isEven ? step + 2 : step + 1;
            }
        }
    }
}
