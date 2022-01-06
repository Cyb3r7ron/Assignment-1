using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is a string reversing code written by Kidus Girma ATE/6954/11

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            string reverseWord = string.Empty;

            Console.WriteLine("Enter any word");
            word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
                reverseWord += word[i];
            Console.WriteLine("Reverse Word :-" + reverseWord);
            Console.ReadKey();
        }
    }
}
// This is a string reversing code written by Kidus Girma ATE/6954/11