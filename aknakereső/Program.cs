using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aknakereső
{
    class Program
    { 
        static void Main(string[] args)
        {
            char[,] pálya = new char[10,10]; 
            Feltöltés(pálya);
            Kirajzoló(pálya);
            Console.ReadKey();
        }
        static void Kirajzoló(char[,] pálya)
        {           
            for (int sor = 0; sor < pálya.GetLength(0); sor++)   
            {
                for (int oszlop = 0; oszlop < pálya.GetLength(1); oszlop++)     
                {
                    Console.Write($"{pálya[sor, oszlop]}|");
                }
                Console.WriteLine();
            }
        }

        static void Feltöltés(char[,] pálya)
        {
            for (int sor = 0; sor < pálya.GetLength(0); sor++)   
            {
                for (int oszlop = 0; oszlop < pálya.GetLength(1); oszlop++)     
                {
                    pálya[sor, oszlop] = '_';
                }
            }
        }
    }
}
