using System;
using System.Security.Cryptography;
using System.Linq;

public class Sorting
{

    public static void Main()
    {

        Random random = new Random();
        int[] collection = new int[30];
        collection.Initialize();
        for (int iterator = 0; iterator < collection.Length; iterator++)
        {
            collection[iterator] = random.Next(1, 10);
        }
        int[] arraysorted = SortHalf(collection.Take((collection.Length + 1) / 2).ToArray());
        collection = SortHalf(collection.Skip((collection.Length + 1) / 2).ToArray());

        printArray(collection);
    }





    public static void printArray(int[] array)
    {

        for (int iterator = 0; iterator < array.Length; iterator++)
        {
            Console.WriteLine($" {array[iterator]}");
        }

    }
    public static int[] Sort(int[] array1, int[] array2)
    {

        int i, j, k;
        int[] array = new int[array1.Length + array2.Length];
        i = 0;
        j = 0;
        k = 0;

        // while(i< )
        return array;


    }

    public static int[] SortHalf(int[] array)
    {

        int _temporalValue = 0;
        int _arrayLenght = array.Length;
        for (int iterator = 0; iterator < (_arrayLenght / 2) - 1; iterator++)
        {
            for (int i = 0; i < array.Length - i - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    _temporalValue = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = _temporalValue;
                }
            }
        }

        return array;
    }


}