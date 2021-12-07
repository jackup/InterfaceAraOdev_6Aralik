using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceAraOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            KrediKartiOdeme krediKartiileOde = new KrediKartiOdeme();
            KapidaOdeme kapidaOde = new KapidaOdeme();
            FastPayOdeme fastPayOdemem = new FastPayOdeme();

            List<KeyValuePair<byte, IOdeme>> OdemeTuruListesi = new List<KeyValuePair<byte, IOdeme>>()
            {
                new KeyValuePair<byte, IOdeme>(1, krediKartiileOde),
                new KeyValuePair<byte, IOdeme>(2, kapidaOde),
                new KeyValuePair<byte, IOdeme>(3, fastPayOdemem)
            };

            foreach (var item in OdemeTuruListesi)
            {
                item.Value.OdemeSekliAyariYap();
            }

            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    krediKartiileOde.OdenecekTutariKullanicidanAl();
                    krediKartiileOde.OdemeYap();
                    break;
                case 2:
                    kapidaOde.OdenecekTutariKullanicidanAl();
                    kapidaOde.OdemeYap();
                    break;
                case 3:
                    fastPayOdemem.OdenecekTutariKullanicidanAl();
                    fastPayOdemem.OdemeYap();
                    break;
                default:
                    Console.WriteLine("Hatalı seçim!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}