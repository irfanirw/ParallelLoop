﻿using System;
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
            var ints = Enumerable.Range(0, 10);

            //Parallel example
            Parallel.For(0, ints.Count(), i =>
            {
                Console.WriteLine("i = " + i + "\tprocId = " + Thread.GetCurrentProcessorId().ToString());
                Thread.Sleep(1000);
                //Console.WriteLine("Wait 1 second");
            });

            //Sequential example
            //for (int i = 0; i < ints.Count(); i++)
            //{
            //    Console.WriteLine("i = " + i);
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Wait 1 second");
            //}
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
