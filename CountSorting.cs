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
            // The output character array that
            // will have sorted arr
            char[] output = new char[n];
            /// Create a count array to store
            // count of individual characters
            // and initialize count array as 0
            int[] count = new int[256];

            for (int i = 0; i < 256; ++i)
                count[i] = 0;
            // store count of each characte
            for (int i = 0; i < n; ++i)
                ++count[array[i]];
            // Change count[i] so that count[i]
            // now contains actual position of
            // this character in output array
            for (int i = 1; i <= 255; ++i)
                count[i] += count[i - 1];
            // Build the output character array
            // To make it stable we are operating in reverse order.
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                --count[array[i]];
            }
            // Copy the output array to arr, so
            // that arr now contains sorted
            // characters
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
