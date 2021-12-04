using System;
using System.Numerics;

namespace REC_84
{
    class Program
    {
        static BigInteger Factorial(int Num)
        {
            int i = 1;
            BigInteger FinalNum = new BigInteger(1);
            FinalNum = 1;
            while (i <= Num) 
            {
                FinalNum = FinalNum * i;
                i++;
            }
            return FinalNum;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int Num = int.Parse(Console.ReadLine());
            Console.Write($"Факториал числа: {Factorial(Num)}");
            Console.ReadKey();
        }
    }
}
