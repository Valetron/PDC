using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
     class ParallelArray
    {
        private int[] data;
        private int compare;
        private int swaps;
        private Stopwatch timer;

        public ParallelArray(int[] data)
        {
            this.data = data;
            swaps = 0;
            compare = 0;
        }

        public string getData()
        {
            string res = "";
            for (int i = 0; i < data.Length; ++i)
                res += data[i].ToString() + ' ';

            return res;
        }

        public int getSize()
        {
            return data.Length;
        }

        public int getCompare()
        {
            return compare;
        }

        public int getSwaps()
        {
            return swaps;
        }

        public bool isSorted()
        {
            for (int i = 1; i < data.Length; ++i)
                if (data[i - 1] > data[i])
                    return false;
            
            return true;
        }

        public Stopwatch getTime()
        {
            return timer;
        }

        private void swap(ref int a, ref int b)
        {
            ++swaps;
            int tmp = a;
            a = b;
            b = tmp;
        }

        public void bubbleSort()
        {
            timer = Stopwatch.StartNew();
            for (int i = 0; i < data.Length; ++i)
            {
                for (int j = 0; j < data.Length - 1; ++j)
                {
                    ++compare;
                    if (data[j] > data[j + 1])
                        swap(ref data[j], ref data[j + 1]);
                }
            }
            timer.Stop();
        }

        public void quickSort()
        {
            timer = Stopwatch.StartNew();
            qSort(data, 0, data.Length - 1);
            timer.Stop();
        }

        private int divide(int[] arr, int start, int end)
        {
            int pivot = end;
            int j = start;

            for (int i = start; i < end; ++i)
            {
                ++compare;
                if (arr[i] < arr[pivot])
                {
                    swap(ref arr[i], ref arr[j]);
                    ++j;
                }
            }

            swap(ref arr[j], ref arr[pivot]);
            return j;
        }

        private void qSort(int[] arr, int start, int end)
        {
            ++compare;
            if (start < end)
            {
                int half = divide(arr, start, end);
                qSort(arr, start, half - 1);
                qSort(arr, half + 1, end);
            }
        }
        
        public void stupidSort()
        {
            timer = Stopwatch.StartNew();
            for (int i = 0; i < data.Length - 1; ++i)
            {
                ++compare;
                if (data[i] > data[i + 1])
                {
                    swap(ref data[i], ref data[i + 1]);
                    i = 0;
                }
            }
            timer.Stop();
        }

    }
}
