using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AlgoTheory_LAB6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> heapData = new List<int>();
            List<float> shellData = new List<float>();
            List<char> countData = new List<char>();
            List<int> dataSize = new List<int>() { 10, 100, 500, 1000, 2000, 5000, 10000 };

            foreach (int i in dataSize)
            {
                Console.WriteLine($"\n=*=*=*= DATA SIZE: {i} =*=*=*=");

                Console.WriteLine("==== Heap Sorting <Array> -> int ===");
                for (int j = i; j > 0; j--)
                {
                    heapData.Add(rnd.Next(0, 100));
                }

                int[] heapArray = heapData.ToArray();

                Stopwatch heapA = new Stopwatch();

                //Console.WriteLine("Before sort:");
                //HeapSorting.Display(heapArray);

                heapA.Start();
                HeapSorting.Sort(ref heapArray);
                heapA.Stop();

                //Console.WriteLine("\nAfter sort:");
                //HeapSorting.Display(heapArray);

                Console.WriteLine("\nTime elapsed: {0}", heapA.Elapsed);

                Console.WriteLine("\n==== Shell Sorting <Array> -> float ===");
                for (int j = i; j > 0; j--)
                {
                    double value = (rnd.NextDouble() * (300 - 0) + 300);
                    if (value > 300)
                    {
                        value -= 300;
                    }
                    shellData.Add((float)value);
                }

                float[] shellArray = shellData.ToArray();

                Stopwatch shellA = new Stopwatch();

                //Console.WriteLine("Before sort:");
                //ShellSorting.Display(shellArray);

                shellA.Start();
                ShellSorting.Sort(ref shellArray);
                shellA.Stop();

                //Console.WriteLine("After sort:");
                //ShellSorting.Display(shellArray);

                Console.WriteLine("\nTime elapsed: {0}", shellA.Elapsed);

                Console.WriteLine("\n==== Count Sorting <Array> -> char ===");
                string chars = "abcdefghijklmnopqrstuvwxyz";
                for (int j = i; j > 0; j--)
                {
                    countData.Add(chars[rnd.Next(0, chars.Length)]);
                }

                char[] countArray = countData.ToArray();

                Stopwatch countA = new Stopwatch();

                //Console.WriteLine("Before sort:");
                //CountSorting.Display(countArray);

                countA.Start();
                CountSorting.Sort(ref countArray);
                countA.Start();

                //Console.WriteLine("\nAfter sort:");
                //CountSorting.Display(countArray);

                Console.WriteLine("\nTime elapsed: {0}", countA.Elapsed);

                heapData.Clear();
                shellData.Clear();
                countData.Clear();
            }
        }
    }
}
