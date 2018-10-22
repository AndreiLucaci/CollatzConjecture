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
                var intermediary = number % 2 == 0 ? number : 3 * number + 1;
                var next = intermediary / 2;

                Console.WriteLine($"[{step}]: {number} => {intermediary} => {next}");

                if (number == 1)
                {
                    return step;
                }

                number = next;
                step = ++step;
            }
        }
    }
}
