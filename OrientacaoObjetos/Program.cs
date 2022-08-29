using System;

namespace OrientacaoObjetos
{
  class Program
  {
    static void Main(string[] args)
    {
      Usuario usuario = new Usuario();
      usuario.setNome("Gabi");
      Console.WriteLine($"Nome do usuário: {usuario.getNome()}");

      Produto produto1 = new Produto();
      produto1.Nome = "Água";
      produto1.Preco = 3.5;
      Console.WriteLine($"Nome do produto: {produto1.Nome}");

      Produto produto2 = new Produto
      {
        Nome = "Coca",
        Preco = 5
      };
      Console.WriteLine($"Nome do produto 2: {produto2.Nome}");
    }
  }
}
