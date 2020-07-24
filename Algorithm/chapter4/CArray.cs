using System;

namespace chapter4
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
        public bool SeqSearch(int sValue)
        {
            if (arr == null)
                return false;
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] == sValue)
                    return true;
            }
            return false;
        }
        public int FindIndex(int sValue)
        {
            if (arr == null)
                return -1;
            for (int index = 1; index < arr.Length; index++)
            {
                if (arr[index] == sValue)
                    return index;
            }
            return -1;
        }
        public int FindMin()
        {
            int min = arr[0];
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] < min)
                    min = arr[index];
            }
            return min;
        }

        public int GetFindMax()
        {
            int max = arr[0];
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] > max)
                    max = arr[index];
            }
            return max;
        }

        public bool SwapSeqSearch(int sValue)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] == sValue)
                {
                    if (index > 0 && index > arr.Length * 0.2)
                    {
                        int temp = arr[index];
                        arr[index] = arr[index - 1];
                        arr[index - 1] = temp;
                    }
                    return true;
                }
            }
            return false;
        }
        public int binSearch(int value)
        {
            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
                if (arr[mid] == value)
                    return mid;
                else
                {
                    if (value < arr[mid])
                        upperBound = mid - 1;
                    else
                        lowerBound = mid + 1;
                }
            }
            return -1;
        }
        public int RbinSearch(int value, int lower, int upper)
        {
            if (lower > upper)
                return -1;
            else
            {
                int mid = (int)(upper + lower) / 2;
                if (value < arr[mid])
                {
                    return RbinSearch(value, lower, mid - 1);
                }
                else if (value == arr[mid])
                    return mid;
                else
                    return RbinSearch(value, mid + 1, upper);
            }
        }
        /// <summary>
        /// 系统二叉树查询
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int BaseBinSearch(int value)
        {
            return Array.BinarySearch(arr, value);
        }
        public int BaseRbinSearch(int value, int lower, int upper)
        {
            return Array.BinarySearch(arr, lower, upper, value);
        }

    }
}
