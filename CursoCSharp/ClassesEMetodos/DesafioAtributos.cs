using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributos
    {
        int a = 10;

        public static void Executar () {
            // Acessar a variável 'a' dentro do método Executar!
            //Console.WriteLine(a);

            DesafioAtributos letra = new DesafioAtributos();
            Console.WriteLine(letra.a);

        }
    }
}
