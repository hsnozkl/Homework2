using System;
using System.Collections;
using System.Collections.Immutable;

namespace Koleksiyonlar_Soru_2;

class Program
{
    static void Main(string[] args)
    {
        //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan.
        //Her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
        //(Array sınıfını kullanarak yazınız.)
        int[] sayidizisi = new int[20];
        for (int i = 0; i < 20; i++) 
        {
            Console.Write($"{i + 1}. sayı ");
            sayidizisi[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(sayidizisi);
        int[] ilkUc = new int[3];
        int ilkUcT = 0;
        for (int i = 0; i < 3; i++)
        {
            ilkUc[i] = sayidizisi[i];
            ilkUcT += ilkUc[i];
        }
        int[] sonUc = new int[3];
        int sonUcT = 0;
        for (int i = 0; i < 3; i++)
        {
            sonUc[i] = sayidizisi[sayidizisi.Length - 3 + i];
            sonUcT += sonUc[i];
        }
        Console.Write("En büyük il üç sayı: ");
        foreach (var item in ilkUc)
        {
            Console.Write(item + " ");
        }
        Console.Write("\nEn küçük ilk üç sayı: ");
        foreach (var item in sonUc)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nEn büyük ilk üç sayının ortalaması: " + ilkUcT / 3);
        Console.WriteLine("En küçük ilk üç sayının ortalaması: " + sonUcT / 3);
        Console.WriteLine("En büyük ve en küçük ilk üç sayının ortalamalarının toplamı: " + ((ilkUcT / 3) + (sonUcT / 3)));
    }
}
