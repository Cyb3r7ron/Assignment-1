using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this code is written to determine the second highest value in an array by Kidus Girma ATE/6954/11
namespace second_largest
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
            Array.Sort(array); //sorting array  
            Array.Reverse(array); // Reverse Sorting array value  
            Console.WriteLine("Second Highest Value In Array " + array[1]);

            foreach (var result in array)
            {
                Console.Write(result + " "); // Array values   
                Console.ReadLine();
            }

        }
    }
}
//this code is written to determine the second highest value in an array by Kidus Girma ATE/6954/11