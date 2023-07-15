using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;



namespace ParallelLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = Enumerable.Range(0, 10);

            var sw = new Stopwatch();

            sw.Start();
            Parallel.For(0, ints.Count(), i =>
            {
                Console.WriteLine("i = " + i + "\tprocId = " + Thread.GetCurrentProcessorId().ToString());
                Thread.Sleep(1000);
            });

            for (int i = 0; i < ints.Count(); i++)
            {
                Console.WriteLine("i = " + i);
                Thread.Sleep(1000);
            }
        }
    }
}
