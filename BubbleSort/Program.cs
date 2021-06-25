using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Enter The Limit");
            var limit = Convert.ToInt32(Console.ReadLine());

            var numberArray = new int[limit];
            Console.WriteLine("Enter The Numbers");
            for(int i = 0; i < limit; i++)
            {
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array before Sorting");
            Console.WriteLine(string.Join(" ",numberArray));

            bubbleSort(numberArray, limit);

            Console.WriteLine("Array after Sorting");
            Console.WriteLine(string.Join(" ", numberArray));
        }

        public static void bubbleSort(int[] numberArray, int limit) {
            for (int i = 0; i < limit-1; i++)
            {
                for (int j = 0; j < limit-i-1; j++)
                {
                    if(numberArray[j] > numberArray[j + 1])
                    {
                        int temp = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = temp;
                    }
                }
            }
        }

    }
}
