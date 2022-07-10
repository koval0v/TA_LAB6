using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoTheory_LAB6
{
    public static class HeapSorting
    {
        public static void Sort(ref int[] array)
        {
            int n = array.Length;

            // Побудова купи
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);
            // Один за іншим "витягуємо" элементи з купи
            for (int i = n - 1; i >= 0; i--)
            {
                // Рухаємо поточний корінь в кінець
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                // Викликаємо процедуру heapify на зменшенній купі
                Heapify(array, i, 0);
            }
        }

        // Метод для зміни в двійкову купу піддерева з кореневим вузлом i, що є
        // індексом в arr[]. n - розмір купи
        public static void Heapify(int[] array, int n, int i)
        {
            int largest = i;
            // Ініціалізуємо найбільший елемент як корінь

            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2
            // Якщо лівий дочірній елемент більше кореня
            if (l < n && array[l] > array[largest])
                largest = l;
            // Якщо правий дочірній елемент більше, ніж найбільший елемент на даний момент
            if (r < n && array[r] > array[largest])
                largest = r;
            // Якщо найбільший елемент - не корінь
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                // Рекурсивно змінюємо в двійкову купу дане піддерево
                Heapify(array, n, largest);
            }
        }

        public static void Display(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
        }
    }
}
