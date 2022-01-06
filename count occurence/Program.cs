using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// this code was written by Kidus Girma ATE/6954/11 to count occurence of each character in a string
namespace count_occurence
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Flutter";
            Console.WriteLine("String: " + str);
            //  first we set the string 
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int cal = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        cal++;
                    }
                }
                // then we check for every character in the string and increment a variable that would count the number of occurrences of that character
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}
// this code was written by Kidus Girma ATE/6954/11 to count occurence of each character in a string
