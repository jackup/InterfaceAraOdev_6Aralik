using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MCD_OOPInterfaceAraOdev
{
    public class KrediKartiOdeme : Odeme, IOdeme
    {
        public string KartSahibiAd { get; set; }
        public string KartSahibiSoyad { get; set; }
        public byte SonKullanimAy { get; set; }
        public int SonKullanimYili { get; set; }
        public short CVV { get; set; }

        private string _kartNumarasi;

        public string KartNumarasi
        {
            get
            {
                return _kartNumarasi;
            }
            set
            {
                char[] dizi = value.ToCharArray();
                bool rakamDegilMi = false;
                foreach (var item in dizi)
                {
                    if (!char.IsDigit(item))//digit olmayan varsa
                    {
                        rakamDegilMi = true; // hemen yakala
                        break;// çık
                    }
                }//döngü bitti


                if (!rakamDegilMi && value.Length == 16)
                {
                    _kartNumarasi = value;
                }
                else
                {
                    throw new FormatException("HATA: Kart numarası 16 haneli değil veya uygun formatta girilmemiştir.");
                }
            }
        }


        public void OdemeSekliAyariYap()
        {
            Console.WriteLine("Kredi Karı --> 1");
        }

        public void OdemeYap()
        {
            Console.WriteLine("Kart Sahibinin Adı: ");
            KartSahibiAd = Console.ReadLine();
            Console.WriteLine("Kart Sahibinin Soyadı: ");
            KartSahibiSoyad = Console.ReadLine();

            Console.WriteLine("16 haneli Kart Numarasını Giriniz: ");
            KartNumarasi = Console.ReadLine();
            Console.WriteLine("Kartınızın son kullanım ay bilgisini 1-12 arasında sayı olarak giriniz: ");
            SonKullanimAy = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Kartınızın son kullanım bilgilerinden yıl bilgisini 20XX formatunda giriniz: ");
            SonKullanimYili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CVV bilgisini giriniz: ");
            CVV = Convert.ToInt16(Console.ReadLine());

            //kartnumarası boş olmamalı ve diğer özelliklerde boş olmamalı encapsulation yap.
            //Bu if' in içindeki koşulları encapsulation ile gerçekleştiriniz.
            //Biz çok vakit harcamamak için if ile yazıp geçmek istedik.
            if (KartSahibiAd.Length > 0 && KartSahibiSoyad.Length > 0 && SonKullanimAy > 0 && SonKullanimAy < 13 && SonKullanimYili >= DateTime.Now.Year)
            {
                Console.Clear();
                Console.WriteLine($"Sayın {KartSahibiAd} {KartSahibiSoyad} {OdenecekTutar} lira ödeniyor...Lütfen bekleyiniz...");
                Random rnd = new Random();
                int bekleme = rnd.Next(3000, 5000);
                Thread.Sleep(bekleme);
                Console.WriteLine("Ödeme alındı...");
            }
        }
    }
}