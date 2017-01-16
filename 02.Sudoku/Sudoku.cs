using System;
using System.Threading;
using System.Globalization;
using System.Linq;

class Sudoku
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input = Console.ReadLine();

        int counter = 0;
        long minute = 0;
        long seconds = 0;
        long totalTime = 0;
        long totalMinutes = 0;
        long totalSeconds = 0;
        while (input != "Quit")
        {
            minute = long.Parse(input.Substring(0, 2));
            seconds = long.Parse(input.Substring(3, 2));
            counter++;
            totalMinutes += minute;
            totalSeconds += seconds;
            input = Console.ReadLine();

        }
        long minSec = totalMinutes * 60;
        totalTime = minSec + totalSeconds;

        double avarageSec = totalTime / counter;
        avarageSec = Math.Round(0.5, (int)avarageSec);
        Console.WriteLine(avarageSec);
        if (avarageSec < 720)
        {
            Console.WriteLine("Gold Star");
        }
        else if (avarageSec < 1440)
        {
            Console.WriteLine("Silver Star");
        }
        else
        {
            Console.WriteLine("Bronze Star");
        }
        Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, avarageSec);
    }
}

