using System;
using System.Collections;
namespace Koleksiyonlar_Soru_3;

class Program
{
    static void Main(string[] args)
    {
        //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız. a, e, ı, i, o, ö, u, ü
        Console.WriteLine("Lütfen bir cümle giriniz:");
        string cumle = Console.ReadLine();

        // Cümle içindeki sesli harfleri bulup diziye atama
        char[] sesliHarfler = GetSesliHarfler(cumle);

        // Sesli harfleri sıralama
        Array.Sort(sesliHarfler);

        // Sonucu ekrana yazdırma
        Console.WriteLine("Cümledeki Sıralı Sesli Harfler:");
        foreach (char harf in sesliHarfler)
        {
            Console.Write(harf + " ");
        }
    }
    static bool IsSesliHarf(char harf)
    {
        // Verilen harfin sesli harf olup olmadığını kontrol et
        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
        return Array.IndexOf(sesliHarfler, harf) != -1;
    }
    static char[] GetSesliHarfler(string cumle)
    {
        // Cümle içindeki sesli harfleri bulup diziye atama
        char[] sesliHarfler = new char[cumle.Length];
        int sesliHarfSayisi = 0;

        for (int i = 0; i < cumle.Length; i++)
        {
            if (IsSesliHarf(cumle[i]))
            {
                sesliHarfler[sesliHarfSayisi] = cumle[i];
                sesliHarfSayisi++;
            }
        }

        // Gerçek boyuta uygun bir dizi oluşturma ve sesli harfleri kopyalama
        char[] result = new char[sesliHarfSayisi];
        Array.Copy(sesliHarfler, result, sesliHarfSayisi);

        return result;
    }
}
