using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Hérbert";
            sicrano.Idade = 28;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 25;

            var apresentacaodoFulano = fulano.Aprensentar();
            fulano.ApresentarNoConsole();
        }
    }
}
