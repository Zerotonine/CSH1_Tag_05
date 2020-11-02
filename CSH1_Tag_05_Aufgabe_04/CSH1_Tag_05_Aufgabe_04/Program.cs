using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_05_Aufgabe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Städte
            int[][][] filialen = new int[3][][];

            //Läden
            filialen[0] = new int[2][];
            filialen[1] = new int[4][];
            filialen[2] = new int[3][];

            //Mitarbeiter
            filialen[0][0] = new int[5];
            filialen[0][1] = new int[2];

            filialen[1][0] = new int[3];
            filialen[1][1] = new int[2];
            filialen[1][2] = new int[1];
            filialen[1][3] = new int[4];

            filialen[2][0] = new int[2];
            filialen[2][1] = new int[2];
            filialen[2][2] = new int[3];

            for(int i = 0; i < filialen.Length; i++)
            {
                for(int j = 0; j < filialen[i].Length; j++)
                {
                    for(int k = 0; k < filialen[i][j].Length; k++)
                    {
                        Console.WriteLine($"Stadt Nr. {i+1}");
                        Console.WriteLine($"Laden Nr. {j+1}");
                        Console.WriteLine($"Mitarbeiter Nr. {k+1}");
                        Console.WriteLine("Wird befüllt!");
                        Console.WriteLine("--------------------------------\n\n");
                        filialen[i][j][k] = -1;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
