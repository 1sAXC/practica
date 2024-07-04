using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика
{
    internal class BubbleSort
    {
        public BubbleSort() { }

        public void Sort(int[] arr) 
        {
            int k;
            do
            {
                k = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        k++;
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    }
                }
            } while (k != 0);
        }  
    }
}
