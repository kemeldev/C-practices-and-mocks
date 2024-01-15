using System;

namespace segundaApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxInt = int.MaxValue;

            // This will throw System.OverflowException
            checked
            {
                int overflowResult = maxInt + 1;
                Console.WriteLine("Overflow result with checked: " + overflowResult);
            }

            // this is something to commit
            // another change to test 123
        }
    }
}