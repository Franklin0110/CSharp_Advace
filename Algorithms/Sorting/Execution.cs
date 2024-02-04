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
            Random random = new Random();
            int[] array = new int[random.Next(1, 30)];
            //Act
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
            sortmethods.SelectionSort(array);

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
