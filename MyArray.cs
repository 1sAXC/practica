using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика
{
    internal class MyArray
    {
        private int[] arr;
        private BubbleSort sort = new BubbleSort();
        private bool isCreated = false;

        public void Create(int length, int min, int max)
        {
            Random rnd = new Random();
            arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }
            isCreated = true;
        }

        public void Sort()
        {
            sort.Sort(arr);
        }

        public int[] GetArray()
        {
            return arr;
        }

        public int GetLegth() 
        { 
            return arr.Length;
        }

        public int GetByIndex(int i)
        {
            return arr[i];
        }

        public bool GetStatus()
        {
            return isCreated;
        }
    }
}
