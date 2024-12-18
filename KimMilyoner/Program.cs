using System;
namespace KimMilyoner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kim Milyoner Olmak İster? yarışmasına hoş geldiniz. \nYarışmamız 3 sorudan ve her bir soru 2 şıktan oluşmaktadır.\n2 Soruya Doğru Cevap Vermeniz Durumunda 1 Milyon TL'lik Ödülü Kazanmış Olacaksınız.");
            Console.WriteLine("-------------------------------------------------------------------");
            int dogruCevapSayisi = 0;
            
            //1. Soru
            Console.WriteLine("1. Soru: Kızınca tüküren hayvan hangisidir?\n\nA) Lama B) Deve");
            Console.WriteLine();
            string cevap1 = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (cevap1 == "a")
            {
                Console.WriteLine("Doğru Cevap!\n---------------------------------------------------------------------");
                
                dogruCevapSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış Cevap! Doğru Cevap A Olacaktı.\n---------------------------------------------------------------------");
            }

            //2. Soru
            Console.WriteLine("2. Soru: Dünyaya en yakın gezegen hangisidir?\n\nA) Venüs B) Mars");
            Console.WriteLine();
            string cevap2 = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (cevap2 == "b")
            {
                Console.WriteLine("Doğru Cevap!\n---------------------------------------------------------------------");
                dogruCevapSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış Cevap! Doğru Cevap B Olacaktı.\n---------------------------------------------------------------------");
            }
            // Eğer 2 doğru cevap alındıysa yarışmayı bitir
            if (dogruCevapSayisi == 2)
            {
                Console.WriteLine("Tebrikler 2 doğru cevaba ulaşarak yarışmayı tamamladınız ve 1 milyon TL değerindeki büyük ödülü kazandınız.\n---------------------------------------------------------------------");
                return; // Yarışma burada sona erer
            }
            //3. Soru
            Console.WriteLine("3. Soru: 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?\n\nA) 7 B) 12");
            Console.WriteLine();
            string cevap3 = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (cevap3 == "b")
            {
                Console.WriteLine("Doğru Cevap!\n---------------------------------------------------------------------");
                dogruCevapSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış Cevap! Doğru Şık B Olacaktı.\n---------------------------------------------------------------------");
            }
        }
    }
}