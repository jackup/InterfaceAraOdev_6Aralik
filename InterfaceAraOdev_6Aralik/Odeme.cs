using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceAraOdev
{
    public class Odeme
    {
        public decimal OdenecekTutar { get; set; }

        public void OdenecekTutariKullanicidanAl()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Ödenecek Tutarı Giriniz:");
            OdenecekTutar = Convert.ToDecimal(Console.ReadLine());

        }

    }
}