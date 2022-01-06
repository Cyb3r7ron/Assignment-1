using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This is a palindrome string code written by Kidus Girma ATE/6954/11
namespace palindrome_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            string reverseWord = string.Empty;

            Console.WriteLine("Enter any word");
            word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)   //this is from my previous code which reverses string entered
                reverseWord += word[i];
            Console.WriteLine("Reverse Word :-" + reverseWord);
            if (word == reverseWord) // Checking whether string is palindrome or not
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", reverseWord, word);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", reverseWord, word);
            }
            Console.ReadKey();
        }
    }
}
// This is a palindrome code written by Kidus Girma ATE/6954/11