namespace Palindrom_Numarası_9
{
    internal class Program
    {
        /*
         ----- 9. Palindrome Number-----
         * 
         Bir tamsayı verildiğinde x, trueeğer xbir ise döndürün
        palindrom
        , ve falseaksi halde .
        
         
        
        Örnek 1:
        
        Giriş: x = 121
         Çıkış: true
         Açıklama: 121, soldan sağa ve sağdan sola 121 olarak okunur.
        Örnek 2:
        
        Giriş: x = -121
         Çıkış: false
         Açıklama: Soldan sağa -121 okunur. Sağdan sola 121- olur. Bu nedenle palindrom değildir.
        Örnek 3:
        
        Giriş: x = 10
         Çıkış: false
         Açıklama: Sağdan sola 01 okur. Bu nedenle palindrom değildir.
         
        
        Kısıtlamalar:
        
        -231 <= x <= 231 - 1
         
        
        Takip: Tamsayıyı bir dizgeye dönüştürmeden çözebilir misiniz?*/


        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));

        }
        static bool IsPalindrome(int x)
        {
            string StrX = x.ToString();
            string yeni = "";
            for (int i = 0; i < StrX.Length; i++)
            {
                yeni = StrX[i] + yeni;
            }
            if (yeni == StrX)
            {
                return true;
            }
            return false;
        }
    }
}
