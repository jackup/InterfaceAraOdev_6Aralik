using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MCD_OOPInterfaceAraOdev
{
    class FastPayOdeme : Odeme, IOdeme
    {
        public string Eposta { get; set; }
        public string Sifre { get; set; }

        public void OdemeSekliAyariYap()
        {
            Console.WriteLine("FastPay --> 3");
        }

        public void OdemeYap()
        {
            Console.WriteLine("Eposta adresi giriniz: ");
            Eposta = Console.ReadLine();
            Console.WriteLine("Şifre giriniz: ");
            Sifre = Console.ReadLine();

            Random rnd = new Random();
            int bekleme = rnd.Next(3000, 5000);
            Console.WriteLine(bekleme);
            for (int i = 0; i < bekleme; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(i + "...");
                Thread.Sleep(bekleme);
            }
            Console.WriteLine("Ödeme alındı.... iyi günler...");
        }
    }
}