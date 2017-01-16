using System;

class Local
{
    static void Main()
    {
        int candidates = int.Parse(Console.ReadLine());
        int vote = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        for(int i = 1; i <= candidates; i++)
        {
            
            if( vote == i)
            {
                if(symbol == 'x' || symbol == 'X')
                {
                    Console.WriteLine(new string('.', 13));
                    Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                    Console.WriteLine("{0}|.\\./.|{0}", new string('.', 3));
                    Console.WriteLine("{0:00}.|..X..|{1}", i, new string('.', 3));
                    Console.WriteLine("{0}|./.\\.|{0}", new string('.', 3));
                }
                else
                {
                    Console.WriteLine(new string('.', 13));
                    Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                    Console.WriteLine("{0}|\\.../|{0}", new string('.', 3));
                    Console.WriteLine("{0:00}.|.\\./.|{1}", i, new string('.', 3));
                    Console.WriteLine("{0}|..V..|{0}", new string('.', 3));
                }
                
            }
            else
            {
                Console.WriteLine(new string('.', 13));
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));
                Console.WriteLine("{0:00}.|{1}|{2}", i, new string('.', 5), new string('.', 3));
                Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));
            }
            Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
        }
        Console.WriteLine(new string('.', 13));
    }
}

