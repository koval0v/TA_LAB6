using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoTheory_LAB6
{
    public static class ShellSorting
    {
        public static void Swap(ref float a, ref float b)
        {
            var t = a;
            a = b;
            b = t;
        }

        public static void Sort(ref float[] array)
        {
            int N = array.Length;
            int h = 1;

            while (h < N / 3)
            {
                h = 3 * h + 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h && array[j] < array[j - h]; j -= h)
                    {
                        Swap(ref array[j], ref array[j - h]);
                    }
                }
                h = h / 3;
            }
        }

        public static void Display(float[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
        }
    }
}
