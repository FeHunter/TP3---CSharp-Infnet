using System;
using System.Globalization;

namespace exercicioTP2
{
    class HelloWorld {
      static void Main() {

        Console.Clear();
        
        Produto p1 = new Produto();
        p1.Nome = "Sapato";
        p1.Quantidade = 5;
        p1.Preco = 54.2;
        Console.WriteLine(p1.ToString());

        ProdutoPerecivel p2 = new ProdutoPerecivel();
        p2.Nome = "Carne";
        p2.Quantidade = 12;
        p2.Preco = 25.39;
        p2.DataDeValidade = DateTime.ParseExact("29/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(p2.ToString());

        Produto p3 = CadastrarProduto();
        Console.WriteLine(p3.ToString());

        ProdutoPerecivel p4 = CadastrarProdutoPerecivel();
        Console.WriteLine(p4.ToString());

      }

      static Produto CadastrarProduto (){
        Console.WriteLine("\nCadastrar Produto");

        Console.Write("Nome:");
        string nome = Console.ReadLine();

        Console.Write("Quantidade:");
        int qtd = int.Parse(Console.ReadLine());

        Console.Write("Preço:");
        double preco = double.Parse(Console.ReadLine());

        Produto produto = new Produto(nome, preco, qtd);
        return produto;
      }

      static ProdutoPerecivel CadastrarProdutoPerecivel (){
        Console.WriteLine("\nCadastrar Produto Perecivel");

        Console.Write("Nome:");
        string nome = Console.ReadLine();

        Console.Write("Quantidade:");
        int qtd = int.Parse(Console.ReadLine());

        Console.Write("Preço:");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Data de validade:");
        DateTime data = DateTime.Parse(Console.ReadLine());

        ProdutoPerecivel produto = new ProdutoPerecivel(nome, preco, qtd, data);
        return produto;
      }
    }
}


