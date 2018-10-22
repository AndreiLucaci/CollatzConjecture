namespace CollatzConjecture.Engine
{
    public interface ICollatzConjectureEngine
    {
        /// <summary>
        /// Implements the Collatz Conjecture
        /// </summary>
        /// <param name="number"><see cref="ulong"/> => The number</param>
        ulong Compute(ulong number);
    }
}