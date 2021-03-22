using System;

namespace Class1
{
    class Program
    {

            static void Main(string[] args)
            {
                urun urun1 = new urun();
                urun1.urun_Adi = "Şarz aleti";
                urun1.Fiyati = 100;
                urun1.Adedi = 47;

                urun urun2 = new urun();
                urun2.urun_Adi = "Kulaklık";
                urun2.Fiyati = 80;
                urun2.Adedi = 15;


                urun urun3 = new urun();
                urun3.urun_Adi = "Kılıf";
                urun3.Fiyati = 50;
                urun3.Adedi = 70;


                urun[] urunler = new urun[] { urun1, urun2, urun3 };

                foreach (var urun in urunler)
                {
                    Console.WriteLine(urun.urun_Adi + " : " + Fiyati + " TL" + " Stok :" + Adedi);
                }

            }
        }

        class urun
        {
            public string urun_Adi { get; set; }
            public int urunFiyati { get; set; }
            public int urunStokAdedi { get; set; }

        }
    }