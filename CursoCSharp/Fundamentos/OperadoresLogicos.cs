using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou a Tv 50? {comprouTv50}");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou a Tv 32? {comprouSorvete}");

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou Tv 32? {comprouTv32}");

            Console.WriteLine($"Mais saudável? {!comprouSorvete}");
        }
                
    }
}
