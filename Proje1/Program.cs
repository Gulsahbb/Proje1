using System;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3.sayıyı giriniz : ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                Console.WriteLine("En büyük değer : " + sayi1);
            }
            else if(sayi2 > sayi1 && sayi2 > sayi3){
                Console.WriteLine("En büyük değer : " + sayi2 );
            }
            else
            {
                Console.WriteLine("En büyük değer : " + sayi3);
            }

            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                Console.WriteLine("En küçük değer : " + sayi1);
            }
            else if (sayi2 < sayi1 && sayi2 < sayi3)
            {
                Console.WriteLine("En küçük değer : " + sayi2);
            }
            else
            {
                Console.WriteLine("En küçük değer : " + sayi3);
            }

        }
    }
}
