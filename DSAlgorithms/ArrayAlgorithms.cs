using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    public class ArrayAlgorithms
    {
        public Boolean LinearSearch(int[] arr, int key)
        {
            foreach (int i in arr)
            {
                if (i == key) return true;
            }
            return false;
        }

        public Boolean LinearSearch2(int[] arr, int key)
        {
            return Array.Find<int>(arr, e => e == key) == key;
        }

        public Boolean BinarySearch(int[] arr, int key)
        {
            int min = 0, max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (arr[mid] == key) return true;
                else if (arr[mid] > key) max--;
                else min++;
            }
            return false;
        }

        public void ReverseArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int t = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = t;
            }
        }

        public void RotateArrayLeft(ref int[] arr, int p)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int t = arr[i];
                arr[i] = arr[(arr.Length - 1)%(i + p) ];
                arr[(arr.Length - 1)%(i + p) ] = t;
            }
        }
    }
}
