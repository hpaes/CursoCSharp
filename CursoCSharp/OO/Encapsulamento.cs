using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("\nFilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amigoDistante = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("\nAmigo distante...");

            Console.WriteLine(amigoDistante.InfoPublica);
            //Console.WriteLine(amigoDistante.CorDoOlho);
            //Console.WriteLine(amigoDistante.NumeroDoCelular);
            //Console.WriteLine(amigoDistante.JeitoDeFalar);
            //Console.WriteLine(amigoDistante.SegredoDeFamilia);
            //Console.WriteLine(amigoDistante.UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento
    {
        public static void Executar() 
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
