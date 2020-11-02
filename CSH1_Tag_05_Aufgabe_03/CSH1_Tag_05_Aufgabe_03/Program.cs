using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_05_Aufgabe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3D array
            string[,,] dim3 = new string[2, 3, 4]    
            {
                {
                    {"Tabelle","Datenbank","Spalte","Zwang"},
                    {"zuweisen","setzen","erhalten","Liste"},
                    { "Puffer","Projekt","Organisation","Interessengruppe"}
                },
                {
                    {"table","database","column","constraint"},
                    {"assign","set","get","list"},
                    {"buffer","project","organization","stakeholder"}
                }
            };
            #endregion

            int iSprache;
            int iFach;
            int iWortnummer;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Bitte Sprache auswählen\n1 - Deutsch\n2 - Englisch");
                Console.Write(">>> ");
                if(validateLanguage(Console.ReadKey().KeyChar, out iSprache))
                {
                    Console.Clear();
                    Console.WriteLine("Bitte Fach angeben:\n1 - SQL\n2 - C#\n3 - PM");
                    Console.Write(">>> ");
                    if(validateCourse(Console.ReadKey().KeyChar, out iFach))
                    {
                        Console.Clear();
                        Console.WriteLine("Bitte Wort wählen (1-4)");
                        Console.Write(">>> ");
                        if(validateWordnumber(Console.ReadKey().KeyChar, out iWortnummer))
                        {
                            Console.Clear();
                            Console.WriteLine($"Ausgabe: {dim3[iSprache-1, iFach-1, iWortnummer-1]}");
                            Console.ReadKey();
                        }
                        else
                        {
                            EingabeFalsch();
                            continue;
                        }
                    }
                    else
                    {
                        EingabeFalsch();
                        continue;
                    }
                }
                else
                {
                    EingabeFalsch();
                    continue;
                }

            }
        }

        static void EingabeFalsch()
        {
            Console.Clear();
            Console.WriteLine("Eingabe ungültig!");
            Console.ReadKey();
        }
        static bool validateLanguage(char eingabe, out int iSprache)
        {
            if(Int32.TryParse(eingabe.ToString(), out int i) && i == 1 || i == 2)
            {
                iSprache = i;
                return true;
            }
            iSprache = -1;
            return false;
        }

        static bool validateCourse(char eingabe, out int iFach)
        {
            if (Int32.TryParse(eingabe.ToString(), out int i) && i == 1 || i == 2 || i == 3)
            {
                iFach = i;
                return true;
            }
            iFach = -1;
            return false;
        }

        static bool validateWordnumber(char eingabe, out int iWort)
        {
            if (Int32.TryParse(eingabe.ToString(), out int i) && i > 0 && i < 5)
            {
                iWort = i;
                return true;
            }
            iWort = -1;
            return false;
        }
    }
}
