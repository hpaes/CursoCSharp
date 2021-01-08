using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar() 
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine().ToLower();

            //if (entrada == "s")
            //    bomComportamento = true;

            bomComportamento = entrada == "s";

            if (nota >= 9.0 && bomComportamento == true)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
