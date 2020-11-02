using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_05_Aufgabe_00
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] album = new string[5, 2]
            {
                {"Old Gods","Abraxis" },
                {"Criminals","Rezz, Malaa" },
                {"The Sloth","Camo & Krooked" },
                {"Formality","Deathpact" },
                {"Alle Scheiße","Favorite" }
            };

            for(int i = 0; i < album.GetLength(0); i++)
            {
                for(int j = 0; j < album.GetLength(1); j++)
                {
                    Console.Write(album[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
