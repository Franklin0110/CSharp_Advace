using System;
using System.Security.Cryptography;
using System.Linq;

public class SortMethods
{
    // <summary>
    /// Returns an sorted array.
    /// <example>
    /// For example:
    /// <code>
    /// int[] array = {5,1,4,3,2}
    /// SortHalf(array)
    /// </code>
    /// Results:
    /// SortedArray = {1,2,3,4,5}  
    /// </example>
    /// </summary>
    public int[] MergeSort(int[] array)
    {
        return (Merge(BubbleSort(array.Take((array.Length + 1) / 2).ToArray()), BubbleSort(array.Skip((array.Length + 1) / 2).ToArray())));
    }

    /// <summary>
    /// This method returns 1 array, merged from 2 arrays
    /// <example>
    /// For example:
    /// <code>
    /// int[] array = {1,3,5,7,9}
    /// int[] array2 = {2,4,6,8,10}
    /// Sort(array,array2)
    /// </code>
    /// Results:
    /// arrayMerged = {1,2,3,4,5,6,7,8,9,10}
    /// </example>
    /// </summary>
    private int[] Merge(int[] array1, int[] array2)
    {
        int iterator2 = 0;
        int[] sortedArray = new int[array1.Length + array2.Length];
        for (int iterator = 0; iterator2 < array1.Length; iterator++)
        {
            sortedArray[iterator] = array1[iterator2];

            iterator++;
            iterator2++;
        }

        iterator2 = 0;
        for (int iterator = 1; iterator2 < array2.Length; iterator++)
        {
            sortedArray[iterator] = array1[iterator2];
            iterator++;
            iterator2++;
        }
        return sortedArray;
    }

    /// <summary>
    /// Returns an sorted array.
    /// <example>
    /// For example:
    /// <code>
    /// int[] array = {5,1,4,3,2}
    /// SortHalf(array)
    /// </code>
    /// Results:
    /// SortedArray = {1,2,3,4,5} 
    /// </example>
    /// </summary>
    public int[] BubbleSort(int[] array)
    {
        int _temporalValue = 0;
        for (int iterator = 0; iterator < array.Length; iterator++)
        {
            for (int i = 0; i < array.Length - 1; i++)
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