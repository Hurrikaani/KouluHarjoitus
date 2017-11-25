﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kouluharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String tiedosto = @"C:\Koodailua\lämpötila.txt";

                if (File.Exists(tiedosto))
                {
                    String aiempiarvo = File.ReadAllText(tiedosto);
                    Console.WriteLine("Aiemmin asetettu arvo oli " + aiempiarvo + " Astetta");
                }
                else
                {
                    Console.WriteLine("Tervetuloa");
                }


                int Lämpötila = 0;
                Console.WriteLine("Anna uusi lämpötila");
                String Syöte = Console.ReadLine();
                Lämpötila = int.Parse(Syöte);

                //Tiedostoon kirjoittaminen
                File.WriteAllText(tiedosto, Lämpötila.ToString());
                Console.WriteLine("Lämpötila on asetettu ja tallennettu");

                Console.ReadLine();
            }
        }
    }
}
