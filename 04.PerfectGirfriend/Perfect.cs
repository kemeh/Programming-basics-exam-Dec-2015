using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PerfectGirfriend
{
    class Perfect
    {
        static void Main()
        {
            string input = Console.ReadLine();

            long dayOfweek = 0;
            long phoneNumber = 0;
            long phoneNumberSum = 0;
            long braSize = 0;
            long nameSum = 0;
            long total = 0;
            long counter = 0;
            char bra;
            char firstLetter;


            while (input != "Enough dates!")
            {
                string[] next = input.Split('\\');
                switch(next[0])
                {
                    case "Monday": dayOfweek = 1;
                        break;
                    case "Tuesday": dayOfweek = 2;
                        break;
                    case "Wednesday": dayOfweek = 3;
                        break;
                    case "Thursday": dayOfweek = 4;
                        break;
                    case "Friday": dayOfweek = 5;
                        break;
                    case "Saturday": dayOfweek = 6;
                        break;
                    case "Sunday": dayOfweek = 7;
                        break;
                }
                phoneNumber = long.Parse(next[1]);
                for (int i = 0; i < next[1].Length; i++)
                {
                    phoneNumberSum += phoneNumber % 10;
                    phoneNumber /= 10;
                }
            
                phoneNumberSum += dayOfweek;
                if (next[2].Length == 4)
                {
                    braSize = long.Parse(next[2].Substring(0, 3));
                    bra = char.Parse(next[2].Substring(3, 1));

                }
                else
                {
                    braSize = long.Parse(next[2].Substring(0, 2));
                    bra = char.Parse(next[2].Substring(2, 1));
                }
                phoneNumberSum += (braSize * bra);
                firstLetter = char.Parse(next[3].Substring(0, 1));
                nameSum = firstLetter * next[3].Length;
                total = phoneNumberSum - nameSum;

                if (total >= 6000)
                {
                    Console.WriteLine("{0} is perfect for you.", next[3]);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", next[3]);
                }
                phoneNumberSum = 0;
                input = Console.ReadLine();
            }
            Console.WriteLine(counter);

          
        }
    }
}
