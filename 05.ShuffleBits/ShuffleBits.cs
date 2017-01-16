using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.ShuffleBits
{
    class ShuffleBits
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            long result = 0;
            string first = GetIntBinaryString(firstNumber);
            string second = GetIntBinaryString(secondNumber);
            string resultBit = "";
            char[] bitssss = first.ToCharArray();
            char[] bitssss2 = second.ToCharArray();

            StringBuilder resultBits = new StringBuilder();


            Console.WriteLine(resultBits);
            if (firstNumber > secondNumber)
            {
                for (int i = 0; i < 32; i++)
                {
                    resultBits.Append(bitssss[i]);
                    resultBits.Append(bitssss2[i]);
                }

            }
            else
            {
                for (int i = 0; i < 32; i += 2)
                {
                    resultBits.Append(bitssss[i]);
                    resultBits.Append(bitssss[i + 1]);
                    resultBits.Append(bitssss2[i]);
                    resultBits.Append(bitssss2[i+ 1]);

                }
            }
            ulong news = Convert.ToUInt64(resultBits);
            Console.WriteLine(news);

        }
        static string GetIntBinaryString(int n)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }
    }
}
