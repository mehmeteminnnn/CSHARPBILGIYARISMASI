using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarışması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogru, yanlis, para;
            para = 0;
            dogru = 0;
            yanlis = 0;
            Console.Title =" Bilgi Yarışması";
            Console.WriteLine("Bilgi Yarışmasına Hoş Geldiniz!");
            Console.WriteLine("Adınızı Giriniz:");
            string ad;
            ad=Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string soyad;
            soyad = Console.ReadLine();
            Console.WriteLine("Soru 1\nSon şampiyonlar ligi şampiyonu takım hangisidir?\nA)Barcelona\nB)Manchester City\nC)Galatasaray\nD)Real Madrid");
            string c1 = Console.ReadLine();
            if (c1 == "D")
            {
                Console.WriteLine("Tebrikler doğru cevap");
                para += 1000;
                dogru++;
            }
            else
            {
                Console.WriteLine("Maalesef yanliş cevap");
                yanlis++;
            }
            Console.WriteLine("Soru 2\nHangisi maydanozgillerdendir?\nA)Elma\nB)Havuç\nC)Muz\nD)Roka");
            string c2 = Console.ReadLine();
            if (c2 == "B")
            {
                Console.WriteLine("Tebrikler doğru cevap");
                para += 1000;
                dogru++;
            }
            else
            {
                Console.WriteLine("Maalesef yanliş cevap");
                yanlis++;
            }
            Console.WriteLine("Soru 3\nHangi romanın yazarı John Steinbeck değildir?\nA)Fareler ve İnsanlar\nB)Hayvan Çiftliği\nC)Gazap Üzümleri\nD)İnci");
            string c3 = Console.ReadLine();
            if (c3 == "B")
            {
                Console.WriteLine("Tebrikler doğru cevap");
                para += 1000;
                dogru++;
            }
            else
            {
                Console.WriteLine("Maalesef yanliş cevap");
                yanlis++;
            }
            Console.WriteLine("AD={0}\nSOYAD={1}\nPARA={2}\nDOĞRU={3}\nYANLIŞ={4}",ad,soyad,para,dogru,yanlis);
            Console.ReadLine();
        }
    }
}
