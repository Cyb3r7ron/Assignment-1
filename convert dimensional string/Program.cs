using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this code is written to convert two dimensional array into one dimensional array by Kidus Girma ATE/6954/11
namespace convert_dimensional_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2] {
         {
            1,
            2
         },{
            3,
            4
            }
         };

            int i, j;
            int[] b = new int[4];
            int k = 0;

            Console.WriteLine("Two-Dimensional Array...");
            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }

            Console.WriteLine("One-Dimensional Array...");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    b[k++] = a[i, j];
                }
            }

            for (i = 0; i < 2 * 2; i++)
            {
                Console.WriteLine("{0}\t", b[i]);
            }
            Console.ReadKey();
            
        }
    }
}
//this code is written to convert two dimensional array into one dimensional array by Kidus Girma ATE/6954/11