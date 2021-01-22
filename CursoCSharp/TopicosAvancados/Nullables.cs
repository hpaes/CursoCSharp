using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar() {
            Nullable<int> num1 = null;
            int? num2 = null;
            int num3;

            // Não dá pra usar um nullable sem definir o valor
            //Console.WriteLine(num3);

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num: {0}", num1);
            } else
            {
                Console.WriteLine("A variável não possui valor.");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();

            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
