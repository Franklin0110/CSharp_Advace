using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Test.Algorithms_Test
{
    public class BoobleSort_Test
    {
        [Fact]
        public void SortMethods_BoobleSort_ReturnArraySorted()
        {
            //Arrange - variables, Classes, Mocks
            SortMethods sort = new SortMethods();
            Random random = new Random();
            int[] array = new int[random.Next(1, 100000)];
            //Act
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100000);
            }
            int[] arraysorted = sort.BoobleSort(array);
            //Assert
            arraysorted.Should().BeInAscendingOrder();
        }
        [Fact]
        public void SortMethods_MergeSort_ReturnArraySorted()
        {
            //Arrange - variables, Classes, Mocks
            SortMethods sort = new SortMethods();
            Random random = new Random();
            int[] array = new int[random.Next(1, 100000)];
            //Act
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100000);
            }
            int[] arraysorted = sort.MergeSort(array);
            //Assert
            arraysorted.Should().BeInAscendingOrder();
        }
    }
}
