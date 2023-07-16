using System;
using System.Collections.Concurrent;
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
            var ints = Enumerable.Range(0, 50);

            // Parallel example
            Parallel.For(0, ints.Count(), i =>
            {
                Console.WriteLine("i = " + i + "\tprocId = " + Thread.GetCurrentProcessorId().ToString());
                Thread.Sleep(1000);
                Console.WriteLine("Wait 1 second================================");
            });

            ///Sequential example
            ///for (int i = 0; i < ints.Count(); i++)
            ///{
            ///    Console.WriteLine("i = " + i);
            ///    Thread.Sleep(1000);
            ///    Console.WriteLine("Wait 1 second");
            ///}

            
            ///string[] colors = {
            ///                      "1. Red",
            ///                      "2. Green",
            ///                      "3. Blue",
            ///                      "4. Yellow",
            ///                      "5. White",
            ///                      "6. Black",
            ///                      "7. Violet",
            ///                      "8. Brown",
            ///                      "9. Orange",
            ///                      "10. Pink"
            ///                  };
            ///Console.WriteLine("Traditional foreach loop\n");
            ///
            ///start the stopwatch for "for" loop
            ///var sw = Stopwatch.StartNew();
            ///foreach (string color in colors)
            ///{
            ///    Console.WriteLine("{0}, Thread Id= {1}", color, Thread.CurrentThread.ManagedThreadId);
            ///    Thread.Sleep(10);
            ///}
            ///Console.WriteLine("foreach loop execution time = {0} seconds\n", sw.Elapsed.TotalSeconds);
            ///Console.WriteLine("Using Parallel.ForEach");
            ///start the stopwatch for "Parallel.ForEach"
            ///sw = Stopwatch.StartNew();
            ///Parallel.ForEach(colors, color =>
            ///{
            ///    Console.WriteLine("{0}, Thread Id= {1}", color, Thread.CurrentThread.ManagedThreadId);
            ///    Thread.Sleep(10);
            ///}
            ///);
            ///Console.WriteLine("Parallel.ForEach() execution time = {0} seconds", sw.Elapsed.TotalSeconds);
            ///Console.Read();
        }

        public static void Reduction(int count)
        {
            //var numArray = Enumerable.Range(1,0).ToArray();
            //Partitioner()
            //
            //for (int i = 0; i < numArray.Length; i++)
            //{
            //    Console.WriteLine()
            //}

        }
    }
}
