using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { -4, 9, 5, 10, 4, 1, -3, 6, 7, -2, 8 };
            int low = 0;
            int high = 10;
            int sum = -1;           

            PrintMyArray(myArray, low, high);

            Sort(myArray, 0, 10);

            PrintMyArray(myArray, low, high);

            //PairValues(myArray, low, high);

            while (low < high)
            {
                if (myArray[low] + myArray[high] == sum)
                {
                    Console.WriteLine("The pair found is in index " + low + ", " + high + " equal to " + sum);
                    Console.ReadLine();
                }
                else if (myArray[low] + myArray[high] < sum)
                { low++; }
                else
                    high--;
            }
            Console.WriteLine("No pairs found");

            Console.ReadLine();
        }
        static void Sort(int[] myArray, int low, int high)
        {
            if (low < high)

            {
                int p = Partition(myArray, low, high);
                Sort(myArray, low, p - 1);
                Sort(myArray, p + 1, high);
            }
        }
        static int Partition(int[] myArray, int low, int high)
        {
            int pivot = myArray[high];
            int i = low;
            for (int j = low; j <= high - 1; j++)
            {
                if (myArray[j] <= pivot)
                {
                    int temp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = temp;
                    i = i + 1;
                }
            }
            int temp2 = myArray[i];
            myArray[i] = myArray[high];
            myArray[high] = temp2;
            return i;
        }
        static void PrintMyArray(int[] myArray, int low, int high)
        {
            for (int i = low; i <= high; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
       /* public static string PairValues(int[] myArray, int low, int high)
        {
            int sum = 26;
            while (low < high)
            {
                if (myArray[low] + myArray[high] == sum)
                {
                    Console.WriteLine("The pair found is " + low + " " + high + " equal to " + sum);
                }
                else if (myArray[low] + myArray[high] < sum)
                { low++; }
                else
                    high--;
                }
            return Console.WriteLine("No pairs found"); 
                

        }*/
    }
}

