using System;
using System.Collections.Generic;
using System.Linq;

namespace desafio_luby
{
  public class Challenges
  {
    public static int CalcularFatorial(int num)
    {
      int fatorial = num;
      for (int i = num; i > 1; i--)
      {
        fatorial = fatorial * (i - 1);
      }
      return fatorial;
    }

    public static double? CalcularPremio(int premio, string tipoDePremio, int? fatorMultiplicacao)
    {
      if (premio < 0) { return null; }

      if (fatorMultiplicacao != null)
      {
        var total = premio * fatorMultiplicacao;
        return total;
      }

      const double BASIC = 1;
      const double VIP = 1.2;
      const double PREMIUM = 1.5;
      const double DELUXE = 1.8;
      const double SPECIAL = 2;

      switch (tipoDePremio)
      {
        case "basic":
          return premio * BASIC;
        case "vip":
          return premio * VIP;
        case "premium":
          return premio * PREMIUM;
        case "deluxe":
          return premio * DELUXE;
        case "special":
          return premio * SPECIAL;
        default:
          return null;
      }
    }

    public static int ContarNumerosPrimos(int num)
    {
      int primos = 0;

      for (int i = 0; i <= num; i++)
      {
        if (i <= 1) { continue; }

        bool primo = true;
        for (int j = 2; j < i; j++)
        {
          if (i % j == 0) { primo = false; }
        }

        if (primo == true) { primos++; }
      }
      return primos;
    }

    public static int CalcularVogais(string str)
    {
      int vogais = 0;
      for (int i = 0; i < str.Length; i++)
      {
        string letra = str[i].ToString().ToLower();
        if ("aeiou".Contains(letra))
        {
          vogais++;
        }
      }
      return vogais;
    }

    public static string CalcularValorComDescontoFormatado(string valor, string porcentagem)
    {
      string strValorFormat = valor.Replace("R$", String.Empty);
      decimal valorFormatado = Decimal.Parse(strValorFormat);

      int porcentagemFormat = Int32.Parse(porcentagem.Replace("%", String.Empty));

      decimal valorComDesconto = valorFormatado - ((valorFormatado * porcentagemFormat) / 100);
      string descontoEmString = valorComDesconto.ToString();
      string descontoFormatado = $"R$ {descontoEmString.Insert(descontoEmString.Length - 6, ".")}";

      return descontoFormatado;
    }

    public static int CalcularDiferencaData(string primeiraData, string segundaData)
    {
      int[] DesestruturarData(string data)
      {
        int dia = Int32.Parse(data.Substring(0, 2));
        int mes = Int32.Parse(data.Substring(2, 2));
        int ano = Int32.Parse(data.Substring(4));
        int[] dataArray = { dia, mes, ano };
        return dataArray;
      }

      DateTime primeiraDataConvertida = new DateTime(
        DesestruturarData(primeiraData)[2],
        DesestruturarData(primeiraData)[1],
        DesestruturarData(primeiraData)[0]
      );
      DateTime segundaDataConvertida = new DateTime(
        DesestruturarData(segundaData)[2],
        DesestruturarData(segundaData)[1],
        DesestruturarData(segundaData)[0]
      );

      TimeSpan diferenca = segundaDataConvertida - primeiraDataConvertida;

      return diferenca.Days;

    }

    public static int[] ObterElementosPares(int[] elementos)
    {
      List<int> lista = new List<int>();
      foreach (int item in elementos)
      {
        if (item % 2 == 0)
        {
          lista.Add(item);
        }
      }

      int[] novoVetor = lista.ToArray();

      return novoVetor;
    }

    public static string[] BuscarPessoa(string[] pessoas, string pesquisa)
    {
      string[] resultado = Array.FindAll(pessoas, x => x.Contains(pesquisa));

      return resultado;
    }

    public static int[][] TransformarEmMatriz(string sequencia)
    {
      string[] nums = sequencia.Split(",");
      List<int[]> lista = new List<int[]>();

      for (int i = 0; i < nums.Length; i += 2)
      {
        lista.Add(new int[] { Int32.Parse(nums[i]), Int32.Parse(nums[i + 1]) });
      }

      int[][] matriz = lista.ToArray();

      foreach (var item in matriz)
      {
        foreach (var item2 in item)
        {
          Console.WriteLine(item2);
        }
        Console.WriteLine("");
      }

      return matriz;
    }

    public static int[] ObterElementosFaltantes(int[] vetor1, int[] vetor2)
    {
      var diferenca = vetor1.Union(vetor2).Except(vetor1.Intersect(vetor2));

      return diferenca.ToArray();
    }
  }
}
