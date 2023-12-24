using System.Collections;

namespace Koleksiyonlar_Soru_1;

class Program
{
    static void Main(string[] args)
    {
        //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

        //Negatif ve numeric olmayan girişleri engelleyin.
        //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

        ArrayList sayilar = new ArrayList();
        ArrayList asal = new ArrayList();
        ArrayList asald = new ArrayList();
        float asaltop = 0;
        float asaldtop = 0;
        int i = 0;
        int n;
        bool dogrugi = false;
        do
        {
            Console.Write($"Pozitif bir sayı girin ({i + 1}. sayı)");
            n = Convert.ToInt32(Console.ReadLine());
            string girdi = Convert.ToString(n);
            dogrugi = int.TryParse(girdi, out n) && n > 0;
            if (!dogrugi)
            {
                Console.WriteLine("Geçerli bir pozitif sayı giriniz");
                i--;
            }
            i++;
            sayilar.Add(n);
        } while (true && i < 20);
        sayilar.Sort();
        foreach (var item in sayilar)
        {
            if (Asalmi((int)item))
            {
                asal.Add(item);
            }
            else
            {
                asald.Add(item);
            }
        }
        Console.WriteLine("Asal olanlar.");
        foreach (var item in asal)
        {
            Console.Write(item + " ");
            asaltop += Convert.ToInt32(item);
        }
        float aslort = asaltop / asal.Count;
        Console.WriteLine("Eleman sayısı: " + asal.Count + " Ortalaması :" + aslort);
        Console.WriteLine("\nAsal olmayanlar.");
        foreach (var item in asald)
        {
            Console.Write(item + " ");
            asaldtop += Convert.ToInt32(item);
        }
        float asldort = asaldtop / asald.Count;
        Console.WriteLine("Eleman sayısı: " + asald.Count + " Ortalaması :" + asldort);
    }
    static bool Asalmi(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
