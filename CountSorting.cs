using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoTheory_LAB6
{
    public static class CountSorting
    {
        public static void Sort(ref char[] array)
        {
            int n = array.Length;

            char[] output = new char[n];

            int[] count = new int[256];

            for (int i = 0; i < 256; ++i)
                count[i] = 0;

            for (int i = 0; i < n; ++i)
                ++count[array[i]];

            for (int i = 1; i <= 255; ++i)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                --count[array[i]];
            }

            for (int i = 0; i < n; ++i)
                array[i] = output[i];
        }

        public static void Display(char[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
        }
    }
}
