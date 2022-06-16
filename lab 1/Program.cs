// Palandrome Lab 3
// Here our simple mindset is to take a user input string and check if it is a palandrome
// I will simply take a string as user input and to check each character I will convert it to char
// Then I need to reverse that char arr So I will use reverse
// Now its reversed string So I will convert it back to string 
// last and if condition to check if they are palandrome

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

            Console.WriteLine("Please Enter a String to check palandrome");
            string userInput = Console.ReadLine();
            char[] inputToChar = userInput.ToCharArray();

            // I took array.reverse from stackOverflow as a refrence
            Array.Reverse(inputToChar);
            string reversedArr = new string(inputToChar);


            if (userInput.Equals(reversedArr))
            {
                Console.WriteLine("Its a Plandrome!!! Yeah");
            }
            else
            {
                Console.WriteLine("Oof !! its not a palandrome");
            }

        }
    }
}