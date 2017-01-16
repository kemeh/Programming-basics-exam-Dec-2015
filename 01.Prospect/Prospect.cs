using System;
using System.Threading;
using System.Globalization;

class Prospect
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        ulong b = ulong.Parse(Console.ReadLine());
        ulong r = ulong.Parse(Console.ReadLine());
        ulong c = ulong.Parse(Console.ReadLine());
        ulong t = ulong.Parse(Console.ReadLine());
        ulong o = ulong.Parse(Console.ReadLine());

        decimal n = decimal.Parse(Console.ReadLine());
        decimal u = decimal.Parse(Console.ReadLine());
        decimal s = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal salaryB = 1500.04M * b;
        decimal salaryR = 2102.10M * r;
        decimal salaryC = 1465.46M * c;
        decimal salaryT = 2053.33M * t;
        decimal salaryO = 3010.98M * o;
        decimal nLV = n * u;
        
        decimal amountNeeded = salaryB + salaryC + salaryO + salaryR + salaryT + nLV + s;

        Console.WriteLine("The amount is: {0:f2} lv.", amountNeeded);
        
        if(amountNeeded > m)
        {
            Console.WriteLine("NO \\ Need more: {0:f2} lv.", Math.Abs(amountNeeded - m));
        }
        else
        {
            Console.WriteLine("YES \\ Left: {0:f2} lv.", m - amountNeeded);
        }


    }
}

