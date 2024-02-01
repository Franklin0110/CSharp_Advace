using System;
using System.Security.Cryptography;


public class Sorting
{

    public static void Main()
    {

        Random random = new Random();
        int[] collection = new int[6];
        collection.Initialize();
        for (int iterator = 0; iterator < collection.Length; iterator++)
        {
            collection[iterator] = random.Next(0, 10);
        }

        printArray(Sort(collection));
    }
    public static void printArray(int[] array)
    {

        for (int iterator = 0; iterator < array.Length; iterator++)
        {
            Console.WriteLine($" {array[iterator]}");
        }

    }


    public static int[] Sort(int[] array)
    {

        int _temporalValue = 0;
        int _arrayLenght = array.Length;
        for (int iterator = 0; iterator < (_arrayLenght / 2) - 1; iterator++)
        {
            if (array[iterator] > array[iterator + 1])
            {
                _temporalValue = array[iterator];
                array[iterator] = array[iterator + 1];
                array[iterator + 1] = _temporalValue;
                iterator = -1;
            }

        }

        for (int iterator = _arrayLenght / 2; iterator < _arrayLenght - 1; iterator++)
        {
            if (array[iterator] > array[iterator + 1])
            {
                _temporalValue = array[iterator];
                array[iterator] = array[iterator + 1];
                array[iterator + 1] = _temporalValue;
                iterator = (_arrayLenght / 2) - 1;

            }

        }
        //BUGGED the numbers from first half are not being ordered with the second half.
        for (int iterator = 0; iterator < _arrayLenght / 2; iterator++)
        {
            if (array[iterator] > array[iterator + _arrayLenght / 2])
            {
                _temporalValue = array[iterator];
                array[iterator] = array[iterator + (_arrayLenght / 2)];
                array[iterator + (_arrayLenght / 2)] = _temporalValue;
                iterator = 0;

            }

        }

        return array;
    }


}