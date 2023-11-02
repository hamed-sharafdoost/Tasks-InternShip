using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.OverLoading_Overriding
{
    public class Time
    {
        private int minutes;
        public Time(int h,int m)
        {
            minutes = h * 60 + m;
        }
        public override string ToString()
        {
            int hour = minutes / 60;
            int minute = minutes % 60;
            string h = string.Empty;
            string m = string.Empty;
            if(hour < 10)
                h = '0' + hour.ToString();
            else
                h = hour.ToString();
            if(minute < 10)
                m = '0' + minute.ToString();
            else
                m = minute.ToString();
            return h + ":" + m;
        }
        public static Time operator + (Time time1,Time time2)
        {
            int totalminutes = time1.minutes + time2.minutes;
            int hour = totalminutes / 60;
            if(hour >= 24)
            {
                hour -= 24;
            }
            return new Time(hour, totalminutes % 60);
        }
        public static Time operator - (Time time1,Time time2)
        {
            int totalminutes = time1.minutes - time2.minutes;
            if(totalminutes < 0)
                totalminutes = (24 * 60) + totalminutes;
            return new Time(totalminutes / 60, totalminutes % 60);
        }
        public void Add(Time time)
        {
            minutes += time.minutes;
            return;
        }
        public void Add(int time)
        {
            minutes += time;
            return;
        }
    }
}
