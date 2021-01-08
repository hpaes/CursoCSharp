namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Aprensentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            System.Console.WriteLine(Aprensentar());
        }
    }
}
