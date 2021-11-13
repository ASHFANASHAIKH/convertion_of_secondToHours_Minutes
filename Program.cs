using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertion_of_secondToMinutes_viceversa
{
    class Program
    {
        static (int hours, int minutes, int seconds) Convert(int seconds)
        {
            int hours, minutes;
            seconds = seconds % (24 * 3600);
            hours = seconds / 3600;
            seconds %= 3600;
            minutes = seconds / 60;
            seconds %= 60;


            Console.WriteLine("Hours = " + hours + ", Minutes =" + minutes + ", Seconds = " + seconds);
            return (hours, minutes, seconds);
        }

        // convertion_of_secondToMinute
        public static void Main()
        {
            int n = 5000;
            Convert(n);
        }
    }
}

