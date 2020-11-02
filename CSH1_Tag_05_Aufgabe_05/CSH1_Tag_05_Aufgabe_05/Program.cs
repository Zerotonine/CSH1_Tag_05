using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_05_Aufgabe_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int schulen, klassen, schueler;
            string name;
            ConsoleColor cc = Console.ForegroundColor;

            Console.WriteLine("Bitte Anzahl Schulen eingeben: ");
            while (!Int32.TryParse(Console.ReadLine(), out schulen) || schulen < 1)
            {
                Console.Clear();
                Console.WriteLine("Bitte Anzahl Schulen eingeben: ");
                continue;
            }

            string[][][] schulaufstellung = new string[schulen][][];

            for(int i = 0; i < schulaufstellung.Length; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Schule Nr. {i+1}/{schulaufstellung.Length}");
                Console.ForegroundColor = cc;

                Console.WriteLine("Bitte Anzahl Klassen eingeben: ");
                while (!Int32.TryParse(Console.ReadLine(), out klassen) || klassen < 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Schule Nr. {i + 1}/{schulaufstellung.Length}");
                    Console.ForegroundColor = cc;
                    Console.WriteLine("Bitte Anzahl Klassen eingeben: ");
                    continue;
                }

                schulaufstellung[i] = new string[klassen][];
            }

            for(int i = 0; i < schulaufstellung.Length; i++)
            {
                for(int j = 0; j < schulaufstellung[i].Length; j++)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Schule Nr. {i + 1}\tKlasse Nr. {j+1}/{schulaufstellung[i].Length}");
                    Console.ForegroundColor = cc;

                    Console.WriteLine("Bitte Anzahl Schüler eingeben: ");
                    while (!Int32.TryParse(Console.ReadLine(), out schueler) || schueler < 1d)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Schule Nr. {i + 1}\tKlasse Nr. {j + 1}/{schulaufstellung[i].Length}");
                        Console.ForegroundColor = cc;
                        Console.WriteLine("Bitte Anzahl Schüler eingeben: ");
                        continue;
                    }
                    schulaufstellung[i][j] = new string[schueler];
                }
            }


            for(int i = 0; i < schulaufstellung.Length; i++)
            {
                for(int j = 0; j < schulaufstellung[i].Length; j++)
                {
                    for(int k = 0; k < schulaufstellung[i][j].Length; k++)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Schule Nr. {i + 1}\tKlasse Nr. {j + 1}\tSchüler Nr. {k+1}/{schulaufstellung[i][j].Length}");
                        Console.ForegroundColor = cc;

                        Console.WriteLine("Bitte Namen des Schülers eingeben: ");

                        while((name = Console.ReadLine()) == "" || name == null)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Schule Nr. {i + 1}\tKlasse Nr. {j + 1}\tSchüler Nr. {k + 1}/{schulaufstellung[i][j].Length}");
                            Console.ForegroundColor = cc;

                            Console.WriteLine("Bitte Namen des Schülers eingeben: ");
                            continue;
                        }

                        schulaufstellung[i][j][k] = name;
                    }
                }
            }

            int iSchule, iKlasse, iSchueler;

            while(true)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Bitte Schule auswählen 1-{schulaufstellung.Length}: ");
                } while (!Int32.TryParse(Console.ReadLine(), out iSchule) || iSchule-1 < 0 || iSchule-1 >= schulaufstellung.Length);

                do
                {
                    Console.Clear();
                    Console.WriteLine($"Bitte Klasse auswählen 1-{schulaufstellung[iSchule-1].Length}: ");
                } while (!Int32.TryParse(Console.ReadLine(), out iKlasse) || iKlasse - 1 < 0 || iKlasse - 1 >= schulaufstellung[iSchule-1].Length);

                do
                {
                    Console.Clear();
                    Console.WriteLine($"Bitte Schüler auswählen 1-{schulaufstellung[iSchule - 1][iKlasse-1].Length}: ");
                } while (!Int32.TryParse(Console.ReadLine(), out iSchueler) || iSchueler - 1 < 0 || iSchueler - 1 >= schulaufstellung[iSchule - 1][iKlasse-1].Length);


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Schule Nr. {iSchule}\tKlasse Nr. {iKlasse}\tSchüler Nr. {iSchueler}");
                Console.ForegroundColor = cc;
                Console.WriteLine($"Name lautet: {schulaufstellung[iSchule-1][iKlasse-1][iSchueler-1]}");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
            }

        }
    }
}
