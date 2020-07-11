using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public static class CalculateAngele
    {
        public static int GetAngel(double hour, double minute)
        {
            if (hour < 0 || hour > 12 || minute < 0 || minute > 60)
            {
                Console.WriteLine("Hours or minutes enter  incorrectly");
                //return -1;
            }

            if (hour == 12 )
            {
                hour = 0;
            }

            if (minute == 60)
            {
                minute = 0;
            }

            // Calculate the angles moved by hour and minute hands 
            // with reference to 12:00 
            int hourAngel = (int) ((hour * 60 + minute) * .5);
            int minuteAngel = (int)(minute * 6);


            // Find the difference between two angles 
            int angle = Math.Abs(hourAngel - minuteAngel);

            // Return the smaller angle of two possible angles 
            //angle = Math.Min(360 - angle, angle);
            return angle;


        }
    }
}
