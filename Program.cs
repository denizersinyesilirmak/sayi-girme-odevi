using System;

class Program
{
    static void Main()
    {
        int toplam = 0;
        int pozitifSayilar = 0;
        int sayi;

        Console.Write("sayı girin: ");
        sayi = int.Parse(Console.ReadLine());

        while (sayi == 0)
        {
            Console.Write("0 dışında bir sayı girin: ");
            sayi = int.Parse(Console.ReadLine());
        }

        while (true)
        {
            if (sayi < 0)
            {
                Console.WriteLine("Pozitif Sayı Girin!!");
            }
            else if (sayi > 0)
            {
                toplam += sayi;
                pozitifSayilar++;
            }

            if (sayi == 0)
            {
                if (pozitifSayilar > 0)
                {
                    double ortalama = (double)toplam / pozitifSayilar;
                    Console.WriteLine($"Toplam: {toplam}");
                    Console.WriteLine($"Ortalama: {ortalama}");
                }
                else
                {
                    Console.WriteLine("Hiç pozitif sayı girilmedi.");
                }
                return;
            }

            Console.Write("sayı girin: ");
            sayi = int.Parse(Console.ReadLine());
        }
    }
}
