using System;

namespace exercicioTP2
{
    class HelloWorld {
      static void Main() {
        
        Produto p1 = new Produto();
        
        p1.Nome = "Sapato";
        p1.Quantidade = 5;
        p1.Preco = 54.2;
        Console.WriteLine(p1.ToString());
      }
    }
}


