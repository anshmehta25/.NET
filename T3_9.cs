using System;

class Clock
{
    private int hour, min, sec;

    public Clock(int hour, int min, int sec)
    {
        this.hour = hour;
        this.min = min;
        this.sec = sec;
    }

    public void Display()
    {
        Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
    }

    public void Increment()
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
    }
}

class T3_9
{
    static void Main()
    {
        Clock c = new Clock(11, 59, 59);
        c.Display();
        c.Increment();
        c.Display();
    }
}