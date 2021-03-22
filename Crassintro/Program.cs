using System;

namespace Crassintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "C# Dersi";
            Kurs1.Egitmen = "Engin Demiroğ";
            Kurs1.İzlenmeOrani = 68;
         
            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "j# Dersi";
            Kurs2.Egitmen = "kerem Variş";
            Kurs2.İzlenmeOrani = 64;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "F# Dersi";
            Kurs3.Egitmen = "Berkan Bilgin";
            Kurs3.İzlenmeOrani = 80;

            Kurs[] kurslar = new Kurs[] {Kurs1, Kurs2, Kurs3 };
        }   
        class Kurs
        {
            public int KursAdi { get; set; }

            public int Egitmen { get; set; }

            public int İzlenmeOrani { get; set; }
        }
    
    }
}
