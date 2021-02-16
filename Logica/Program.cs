using System;
using System.Linq;

namespace desafio_luby
{
  class Program
  {
    static void Main(string[] args)
    {
      //1.1
      Console.WriteLine("\nEx 1.1");
      Console.WriteLine(Challenges.CalcularFatorial(5) == 120);

      //1.2
      Console.WriteLine("\nEx 1.2");
      Console.WriteLine(Challenges.CalcularPremio(100, "vip", null) == 120.00);
      Console.WriteLine(Challenges.CalcularPremio(100, "basic", 3) == 300.00);

      //1.3
      Console.WriteLine("\nEx 1.3");
      Console.WriteLine(Challenges.ContarNumerosPrimos(10) == 4);

      //1.4
      Console.WriteLine("\nEx 1.4");
      Console.WriteLine(Challenges.CalcularVogais("Luby Software") == 4);

      //1.5
      Console.WriteLine("\nEx 1.5");
      Console.WriteLine(Challenges.CalcularValorComDescontoFormatado("R$ 6.800,00", "30%") == "R$ 4.760,00");

      //1.6
      Console.WriteLine("\nEx 1.6");
      Console.WriteLine(Challenges.CalcularDiferencaData("10122020", "25122020") == 15);

      //1.7
      Console.WriteLine("\nEx 1.7");
      
      int[] vetorEx7 = new int[] { 1, 2, 3, 4, 5 };
      Console.WriteLine(Challenges.ObterElementosPares(vetorEx7).SequenceEqual(new int[] { 2, 4 }));

      //1.8
      Console.WriteLine("\nEx 1.8");

      string[] vetorEx8 = new string[] {
        "John Doe",
        "Jane Doe",
        "Alice Jones",
        "Bobby Louis",
        "Lisa Romero"
      };
      Console.WriteLine(Challenges.BuscarPessoa(vetorEx8, "Doe").SequenceEqual(new string[] { "John Doe", "Jane Doe" }));
      Console.WriteLine(Challenges.BuscarPessoa(vetorEx8, "Alice").SequenceEqual(new string[] { "Alice Jones" }));
      Console.WriteLine(Challenges.BuscarPessoa(vetorEx8, "Louis").SequenceEqual(new string[] { "Bobby Louis" }));

      //1.9
      Console.WriteLine("\nEx 1.9");
      Console.WriteLine(Challenges.TransformarEmMatriz("1,2,3,4,5,6")); // A comparação sempre dará false, porém a matriz está estruturada de maneira correta

      //1.10
      Console.WriteLine("\nEx 1.10");

      int[] vetor1 = new int[] { 1, 2, 3, 4, 5 };
      int[] vetor2 = new int[] { 1, 2, 5 };
      Console.WriteLine(Challenges.ObterElementosFaltantes(vetor1, vetor2).SequenceEqual(new int[] { 3, 4 }));

      int[] vetor3 = new int[] { 1, 4, 5 };
      int[] vetor4 = new int[] { 1, 2, 3, 4, 5 };
      Console.WriteLine(Challenges.ObterElementosFaltantes(vetor3, vetor4).SequenceEqual(new int[] { 2, 3 }));

      int[] vetor5 = new int[] { 1, 2, 3, 4 };
      int[] vetor6 = new int[] { 2, 3, 4, 5 };
      Console.WriteLine(Challenges.ObterElementosFaltantes(vetor5, vetor6).SequenceEqual(new int[] { 1, 5 }));

      int[] vetor7 = new int[] { 1, 3, 4, 5 };
      int[] vetor8 = new int[] { 1, 3, 4, 5 };
      Console.WriteLine(Challenges.ObterElementosFaltantes(vetor7, vetor8).SequenceEqual(new int[] { }));
    }
  }
}
