using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// this code is written to find all possible substrings of a given string by Kidus Girma ATE/6954/11
namespace substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();

            Console.WriteLine("All substrings for given string are : ");

            for (int i = 0; i < inputString.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(inputString.Length - i);
                for (int j = i; j < inputString.Length; ++j)
                {
                    subString.Append(inputString[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
// this code is written to find all possible substrings of a given string by Kidus Girma ATE/6954/11