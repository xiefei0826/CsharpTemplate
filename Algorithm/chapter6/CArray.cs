using System;

namespace chapter6
{
    public class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;
        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }
        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
            }
            numElements = 0;
        }
        public void BubbleSort()
        {
            int temp;
            for (int outer = upper; outer > 0; outer--)
            {
                for (int inner = 0; inner < outer; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                    this.DisplayElements();
                }
                this.DisplayElements();
            }
        }
        public void SelectionSort()
        {
            int min, temp;
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)
                {
                    if (arr[inner] < arr[min])
                        min = inner;
                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
                this.DisplayElements();
            }
        }
        public void InsertionSort()
        {
            int inner, temp;
            for (int outer = 1; outer <= upper; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while (inner > 0 && arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;
                this.DisplayElements();
            }
        }
        public void GenPrimes()
        {
            for (int outer = 2; outer <= arr.GetUpperBound(0); outer++)
            {
                for (int inner = outer + 1; inner < arr.GetUpperBound(0); inner++)
                {
                    if (arr[inner] == 1)
                    {
                        if ((inner % outer) == 0)
                            arr[inner] = 0;
                    }
                }
            }
        }
        public void ShowPrimes()
        {
            for (int i = 2; i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i] == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
