using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        try
        {
            // Kullanıcıdan bir sayı girmesini istiyoruz
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            // Sayının karesini hesaplayıp ekrana yazdırıyoruz
            int kare = sayi * sayi;
            Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
        }
        catch (FormatException)
        {
            // Kullanıcı geçersiz bir giriş yaparsa hata mesajı gösteriyoruz
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
    }
}

