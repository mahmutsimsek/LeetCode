namespace Sqrt_x__69
{
    internal class Program
    {
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