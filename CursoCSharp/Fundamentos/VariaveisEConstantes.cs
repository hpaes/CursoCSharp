using System;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() 
        {
            // Área de circunferência
            double raio = 4.5;
            const double PI = Math.PI;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("Área é " + area);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MaxValue;
            Console.WriteLine("Saldo de gols foi " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorint = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorint);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira " + populacaoBrasileira);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais!
            Console.WriteLine("Valor de mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas " + distanciaEntreAsEstrelas);

            char letra = 'a';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#";
            Console.WriteLine("Texto " + texto);
        } 
    }
}
