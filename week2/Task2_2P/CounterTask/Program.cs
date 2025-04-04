using System;
namespace CounterTask
{
    internal class Program
    {
        private static void PrintCounters(Counter[] counters)
        {
            foreach (Counter c in counters)
            {
                Console.WriteLine("{0} is {1}", c.Name, c.Ticks);
            }
        }

        static void Main(string[] args)
        {
            Counter[] myCounters = null;
            int X = 3;
            myCounters[X] = new Counter("My counter");
        }
    }
}
