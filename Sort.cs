using System;

namespace CSharp_Algorithm
{
    class SortAlgorithm
    {
        public static void BubbleSort(int[] array, int size)
        {
            int temp;
            bool swapped;

            for(int i = 0; i < size - 1; i++)
            {
                swapped = false;
                for(int j = 0; j < size - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                /* 한번도 스왑이 일어나지 않았다면 
                 * 이미 정렬이 완료됐으니 정렬 종료
                */
                if (swapped == false)
                    break;
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 5, 4, 3, 2, 6 };
            SortAlgorithm.BubbleSort(arr, 5);

            foreach(var i in  arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
