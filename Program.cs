using System;
using System.IO;

namespace MeuSegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dados = @"L:\LAB01\ALgoritimos e Programacao\" +
                @"MeuSegundoProjeto\MeuSegundoProjeto\dados.txt";

            Console.WriteLine("Carregando dados. Aguarde...");
            var texto = File.ReadAllText(dados);

            Console.WriteLine(texto);
            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
