namespace Sqrt_x__69
{
    internal class Program
    {/*
     ----- 69. Sqrt(x)----
      *
        Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

        You must not use any built-in exponent function or operator.
        
        For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
         
        
        Example 1:
        
        Input: x = 4
        Output: 2
        Explanation: The square root of 4 is 2, so we return 2.
        Example 2:
        
        Input: x = 8
        Output: 2
        Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest  integer, 2    is returned.
         
        
        Constraints:
        
        0 <= x <= 231 - 1
              */
        static void Main(string[] args)
        {
            Console.WriteLine(  MySqrt(2147483647) );
        }
        static int MySqrt(int x)
        {
            int deger = 0;
            if (x==0)
            {
                return 0;
            }
             if (x == 1)
            {
                return 1;
            }
             if (x == 2)
            {
                return 1;
            }

            for (int i = 0; i < x; i++)
            {
                int ikare = i * i;
                if ((ikare < x)&&((i+1)*(i+1))>x)
                {
                    //
                    deger = i;
                    break;
                   
                }
                if ( Math.BigMul(i,i) > x)
                {
                    deger = i-1;
                    break;
                }
                if (ikare == x)
                {
                    deger = i ;
                    break;
                }
                
            }
            return deger;
        }
    }
}