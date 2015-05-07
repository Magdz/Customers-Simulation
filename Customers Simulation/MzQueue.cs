using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers_Simulation
{
    class MzQueue
    {
        private static int front, rear, numberItems, Capacity;
        private static int[] items;

        public MzQueue(int size){
            rear=0;
            front=0;
            numberItems=0;
            Capacity=size;
            items = new int[size];
        }

        public void Enqueue(int value)
        {
            rear++;
            if (isEmpty()) rear = 0;
            items[rear] = value;
            numberItems++;
        }

        public int Dequeue()
        {
            front %= Capacity;
            int data = items[front];
            front++;
            numberItems--;
            return data;
        }

        public bool isEmpty()
        {
            if (numberItems == 0)
                return true;
            return false;
        }

        public bool isFull()
        {
            if (numberItems == Capacity)
                return true;
            return false;
        }

        public void sort()
        {
            // Quick Sort Running time : O(nlogn) & Best Case time : O(n)
            //Qsort(front, rear);
            MergeSort(items);
        }

        private void MergeSort(int[] arr)
        {
            int[] temp = new int[arr.Length];
            merge_sort(arr, temp, 0, arr.Length - 1);
        }

        private void merge_sort(int[] arr, int[] temp, int low, int high)
        {
            if (low >= high) return;
            int mid = (low + high) / 2;
            merge_sort(arr, temp, low, mid);
            merge_sort(arr, temp, mid + 1, high);
            merge(arr, temp, low, mid, mid + 1, high);
        }

        private void merge(int[] arr, int[] temp, int low1, int high1, int low2, int high2)
        {
            int i = low1, j = low2, k = 0;
            while (i <= high1 && j <= high2)
                if (arr[i] < arr[j]) temp[k++] = arr[i++];
                else temp[k++] = arr[j++];
            while (i <= high1) temp[k++] = arr[i++];
            while (j <= high2) temp[k++] = arr[j++];
            for (int l = 0, t = Math.Min(low1, low2); t <= Math.Max(high1, high2); ++l, ++t)
                arr[t] = temp[l];
        }

        private static void Qsort(int low,int high)
        {
            if(low>=high) return;
            int left = low, right = high, i = low;
            while (i <= right)
            {
                if (items[i] < items[left])
                {
                    swap(left, i);
                    left++;
                    i++;
                }
                else if (items[i] > items[left])
                {
                    swap(i, right);
                    right--;
                }
                else i++;
            }
            Qsort(low, left - 1);
            Qsort(right + 1, high);
        }

        private static void swap(int x, int y)
        {
            int temp = items[x];
            items[x] = items[y];
            items[y] = temp;
        }
    }
}
