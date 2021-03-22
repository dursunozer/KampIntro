using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Oyuncülar =new string[] {"LewanGoalski", "Müller", "Boateng", "Never"};

            for (int i = 0; i < Oyuncülar.Length; i++)
            {
                Console.WriteLine(Oyuncülar[i]);
            }
            foreach (string oyuncü in Oyuncülar)
            {
                Console.WriteLine(oyuncü);
            }
        }
    }
}
