using System;
using System.Collections.Generic;
using System.Linq;

namespace NotOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> notlar = new List<double>();
            int i = 0;
            string x;
            string ciksinMi = "";
            do
            {
                Console.WriteLine("Lütfen {0}. notu giriniz :", i + 1);
                x = Console.ReadLine();
                notlar.Add(Convert.ToDouble(x));
                Console.WriteLine("Hesaplansın mı? E/H : ");
                ciksinMi = Console.ReadLine();
                i++;
            }
            while (!(ciksinMi == "E" || ciksinMi == "e"));
            Console.WriteLine("Notlar toplamı : {0}", notlar.Sum());
            double ortalama = notlar.Sum() / (i);
            Console.WriteLine("Not ortalaması : {0}", ortalama);
        }
    }
}
