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
            Console.WriteLine("Please Enter an integer");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please enter {n} Words");
            string[] input = new string[n];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }
            char[] arr = new char[input.Length];
            Console.WriteLine("Please Enter a character");

            char ch = Console.ReadKey().KeyChar;
            int count = 0;
            int perecentage = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (ch == arr[i])
            //    { 
            //        count++;
            //    }else
            //    {
            //        perecentage++;
            //    }
            //}

            Console.WriteLine($" The Letter '{ch}' appeared {count} times in the array. This letter make up {perecentage} of the total number of Characters.");

        }
    }
}
