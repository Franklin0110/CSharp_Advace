using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Execution
    {

        public static void Main()
        {
            SortMethods sortmethods = new SortMethods();
            int[] array = { 7, 3, 5, 4, 8, 9 };
            printArray(sortmethods.MergeSort(array));

        }
        /// <summary>
        /// Prints in console an array
        /// <example>
        /// For example:
        /// <code>
        /// int[] array = new int[1,2,3,4,5]
        /// printArray(array)
        /// </code>
        /// Results:
        /// 1 2 3 4 5
        /// </example>
        /// </summary>
        public static void printArray(int[] array)
        {
            Console.Write("Results: ");
            for (int iterator = 0; iterator < array.Length; iterator++)
            {
                Console.Write($" {array[iterator]}");
            }
        }
    }
}
