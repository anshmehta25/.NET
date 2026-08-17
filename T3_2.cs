
using System;

namespace T3_2
{
    class Clock
    {
        private int hour;
        private int min;
        private int sec;

        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        public Clock(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }

        public void IncrementSecond()
        {
            sec++;

            if (sec == 60)
            {
                sec = 0;
                min++;
            }

            if (min == 60)
            {
                min = 0;
                hour++;
            }

            if (hour == 24)
            {
                hour = 0;
            }
        }

        public void DisplayTime()
        {
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
        }

        public int getHour()
        {
            return hour;
        }

        public int getMinute()
        {
            return min;
        }

        public int getSeconds()
        {
            return sec;
        }
    }

    class TestClock
    {
        static void Main(string[] args)
        {
            Clock c1 = new Clock();
            Clock c2 = new Clock(10, 59, 59);

            Console.WriteLine("Default Time:");
            c1.DisplayTime();

            Console.WriteLine("Given Time:");
            c2.DisplayTime();

            c2.IncrementSecond();
            Console.WriteLine("After increment:");
            c2.DisplayTime();
        }
    }
}
