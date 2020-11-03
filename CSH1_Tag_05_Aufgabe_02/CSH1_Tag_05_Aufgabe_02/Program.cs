using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_05_Aufgabe_02
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] tipp = new int[6];
            int[] auslosung = new int[6];
            int durchlaeufe = 0;
            int treffer = 0;

            string[,] auslosungen = new string[10, 3]; //Row = Durchlauf; Column = Tipp, Losung, Treffer; 

            FuelleLottoArray(ref tipp);
            do
            {
                
                FuelleLottoArray(ref auslosung);
                treffer = ZaehleTreffer(ref tipp, ref auslosung);
                Array.Sort(tipp);
                Array.Sort(auslosung);
                Console.WriteLine($"Durchlauf Nr. {durchlaeufe+1}:");
                Console.WriteLine($"Tipp:\t\t{String.Join(", ", tipp)}");
                Console.WriteLine($"Auslosung:\t{String.Join(", ", auslosung)}");
                Console.WriteLine($"Treffer:\t{treffer}");
                Console.Write("--------------------------------------------\n\n");

                auslosungen[durchlaeufe, 0] = String.Join(", ", tipp);
                auslosungen[durchlaeufe, 1] = String.Join(", ", auslosung);
                auslosungen[durchlaeufe, 2] = treffer.ToString();


                durchlaeufe++;
                Console.ReadKey();
                Console.Clear();
            } while (treffer < 3 && durchlaeufe < 10);

            for(int i = 0; i < auslosungen.GetLength(0); i++)
            {
                if (auslosungen[i, 0] == null)
                    break;
                Console.WriteLine($"Durchlauf Nr. {i+1}");
                for(int j = 0; j < auslosungen.GetLength(1); j++)
                {
                    switch(j)
                    {
                        case 0:
                            Console.Write("Tipp:\t\t");
                            break;
                        case 1:
                            Console.Write("Auslosung:\t");
                            break;
                        case 2:
                            Console.Write("Treffer:\t");
                            break;
                    }
                    Console.WriteLine(auslosungen[i, j]);
                }
                Console.WriteLine("-------------------------------\n\n");
            }

            Console.ReadKey();
        }

        static void FuelleLottoArray (ref int[] lottoZahlen)
        {
            int i = 0, zahl=rnd.Next(1,50);
            do
            {
                zahl = rnd.Next(1, 50);
                if(!lottoZahlen.Contains(zahl))
                {
                    lottoZahlen[i] = zahl;
                    i++;
                }
                else
                {
                    continue;
                }
            } while (i < lottoZahlen.Length);
        }

        static int ZaehleTreffer(ref int[] a, ref int[] b)
        {
            int treffer = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if(b.Contains(a[i]))
                {
                    treffer++;
                }
            }
            return treffer;
        }
    }
}
