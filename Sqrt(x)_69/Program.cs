﻿namespace Sqrt_x__69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  MySqrt(50) );
        }
        static int MySqrt(int x)
        {
            int deger = 0;
          
            for (int i = 0; i < x; i++)
            {
                if (i*i>x)
                {
                    deger = i-1;
                    break;
                }
            }
            return deger;
        }
    }
}