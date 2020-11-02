using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_05_Aufgabe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] lexikon = new string[2, 3]
            {
                {   "developer",
                    "C#",
                    "internet"
                },
                {   "loser office worker who spends his time writing code for da man. Also know as code monkey",
                    "A perversion of the greatest programming language, C. This abomination is proprietary, and no programmer living in the real world would use it.",
                    "A virtual place where everyone feels they have the right to force their opinions, offend, and engage in verbal barbarism between other users"
                }
            };

            while(true)
            {
                Console.Write("Bitte Suchbegriff eingeben: ");
                string suche = Console.ReadLine();
                Console.Clear();

                for(int i = 0; i < lexikon.GetLength(1); i++)
                {
                    if(lexikon[0, i].ToLower() == suche.ToLower())
                    {
                        Console.WriteLine($"Suchbegriff:\t{suche}\n");
                        Console.WriteLine($"Erläuterung:\t{lexikon[1,i]}");
                        break;
                    }
                    else if(i == lexikon.GetLength(1)-1)
                    {
                        Console.WriteLine($"Begiff {suche} nicht gefunden!");
                    }
                }

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
                Console.Clear();
            }
        }
    }
}
