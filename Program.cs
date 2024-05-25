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
      }
    }
}


