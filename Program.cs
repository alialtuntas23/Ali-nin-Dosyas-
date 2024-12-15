using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] adet = { 200, 100, 50, 20, 10, 5 };
            int[] miktar = { 0, 0, 0, 4, 4, 4 };

            Console.Write("Çekeceğiniz para miktarını giriniz! ");
            int s1 = int.Parse(Console.ReadLine());

            if (s1 < 100)
            {
                Console.WriteLine("Maalesef en az 100 Tl çekebilirsiniz! ");
                return;
            }
            else if (s1 > 5000)
            {
                Console.WriteLine("Maalesef en fazla 5000 Tl Çekebilirsiniz! ");
            }

            int kalanTutar = s1;
            int[] kullanilanBanknot = new int[adet.Length];

            for (int i = adet.Length - 1; i >= 0; i--)
            {
                if (miktar[i] > 0)
                {
                    kullanilanBanknot[i] = Math.Min(kalanTutar / adet[i], miktar[i]);
                    kalanTutar -= kullanilanBanknot[i] * adet[i];
                }
            }

            for (int i = 0; i < adet.Length; i++)
            {
                if (kalanTutar == 0) break;
                kullanilanBanknot[i] += kalanTutar / adet[i];
                kalanTutar %= adet[i];
            }

            if (kalanTutar > 0)
            {
                Console.WriteLine("maalesef hata");
                return;
            }

            Console.WriteLine("Banknot adetleri");
            for (int i = 0; i < adet.Length; i++)
            {
                if (kullanilanBanknot[i] > 0)
                {
                    Console.WriteLine($"{kullanilanBanknot[i]} adet {adet[i]} TL");
                }
            }
            Console.ReadKey();
        }
    }
}
