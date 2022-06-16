using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lab 4

            // part 1
            // we simply need to use List.max as given

            var list1 = new List<int> { 1, 5, 3 };
            var list2 = new List<int> { 9, 7, 3, -2 };
            var list3 = new List<int> { 5, 9, 2 };

            Console.WriteLine($"List 1 has maximum of {list1.Max()}. List 2 has a maximum of {list2.Max()} List 3 has a maximum of {list3.Max()}");

            // part 2
            // Highest Grades

            var sub1 = new List<int> { 85, 92, 67, 94, 94 };
            var sub2 = new List<int> { 50, 60, 57, 95 };
            var sub3 = new List<int> { 95 };

            var grades = new List<int> { sub1.Max(), sub2.Max(), sub3.Max() };
            Console.WriteLine($"The highest grade is {grades.Max()}.");

            //part 3
            // Simple Bubble sort
            // refrence stack overflow and youtube

            int[] arr = { 6, -2, 5, 3 };
            int temp;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            foreach (var i in arr)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
