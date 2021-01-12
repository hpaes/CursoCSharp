using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar() 
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1;
            ponto1.X = 3;

            Console.WriteLine($"Ponto 1 X: {ponto1.X}");
            Console.WriteLine($"Copia Ponto 1 X: {copiaPonto1}");
        }
    }
}
