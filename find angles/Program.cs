using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this code is written to find the angle between hour hand and minute hand by Kidus Girma ATE/6954/11

namespace find_angles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minutes : ");
            int minutes = int.Parse(Console.ReadLine());

            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteInDegrees = minutes * 6;
            double diff = Math.Abs(hourInDegrees - minuteInDegrees);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"Angle between {hours} hour and {minutes} minute is {diff} degrees");
            Console.ReadKey();
        }
    }
}
//this code is written to find the angle between hour hand and minute hand by Kidus Girma ATE/6954/11
