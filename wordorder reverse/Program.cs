using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is a code written to reverse the order of words in a sentence by Kidus Girma ATE/6954/11
namespace wordorder_reverse
{
    class Program
    {
        static void rev(string rec)
        {
            int i; int st = rec.Length - 1; int en = rec.Length - 1;
            StringBuilder b1 = new StringBuilder();
            while (st > 0)
            {
                if(rec[st] == ' ')
                {
                    i = st + 1;
                    while (i <= en)
                    {
                        b1.Append(rec[i]);
                        i++;
                    }
                    b1.Append(' ');
                    en = st - 1;
                }
                st--;
            }
            for(i = 0; i <= en; i++)
            {
                b1.Append(rec[i]);
            }
            Console.WriteLine(b1.ToString());
        }
        static void Main(string[] args)
        {
            Console.Write("Enter any sentence: ");
            String str = Console.ReadLine();
            rev(str);
            Console.ReadLine();
        }
    }
}
//This is a code written to reverse the order of words in a sentence by Kidus Girma ATE/6954/11 