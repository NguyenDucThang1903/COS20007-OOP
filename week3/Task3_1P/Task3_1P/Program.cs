using System.Diagnostics;
using System.Runtime.Serialization.Formatters;

namespace Task3_1P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock myclock = new Clock();
            for (int i=0; i<= 473; i++) //43200
            {
                
                Console.WriteLine(myclock.ClockTime);
                myclock.Tick();
            }

            System.Diagnostics.Process proc =
System.Diagnostics.Process.GetCurrentProcess();
            Console.WriteLine("Current process: {0}", proc.ToString());
            Console.WriteLine("Physical memory usage: {0} bytes",
proc.WorkingSet64);
            Console.WriteLine("Peak physical memory usage {0} bytes",
proc.PeakWorkingSet64);

        }
    }
}
