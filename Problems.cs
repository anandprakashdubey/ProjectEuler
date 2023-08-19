using System;

namespace ProjectEuler
{
    public class Problems
    {
        /// <summary>
        /// Multiple Of 3 or 5
        /// </summary>
        /// <param name="maxCount"></param>
        /// <returns></returns>
        public static double MultipleOf3or5(int maxCount)
        {
            var result = Enumerable.Range(0, maxCount).Where(i => i % 3 == 0 || i % 5 == 0).Select(x => x).Sum();

            return result;
        }

        /// <summary>
        /// Even Fibonacci Numbers
        /// </summary>
        /// <param name="maxCount"></param>
        public static void EvenFibonacciNumbers(ulong maxCount)
        {
            ulong[] fib = new ulong[maxCount + 1];

            for (ulong i = 1; i <= maxCount; i++)
            {
                fib[i] = i == 0 || i == 1 || i == 2 ? i : (fib[i - 1] + fib[i - 2]);
            }

            Console.WriteLine("Sum of Fibonaci Series Under Given number {0} is {1}",maxCount, fib.Where(i => i < 4000000).Where(i => i % 2 == 0).Aggregate((a, b) => a + b));
        }
    }
}
