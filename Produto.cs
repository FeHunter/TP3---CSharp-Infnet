using System;

namespace exercicioTP2
{
    public class Produto : IDescontavel
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        private double _desconto = 0;
        
        public  string Nome { get{ return _nome; } set { _nome = value; } }
        public double Preco { get{ return _preco; } set{ _preco = value; } }
        public int Quantidade { get{ return _quantidade; } set{ _quantidade = value; } }
        public double Desconto { get => _desconto; set => _desconto = value; }

        public Produto (){
        }
        public Produto (string Nome, double Preco, int Quantidade){
            _nome = Nome;
            _preco = Preco;
            _quantidade = Quantidade;
        }
        public Produto (string Nome, double Preco, int Quantidade, double Desconto){
            _nome = Nome;
            _preco = Preco;
            _quantidade = Quantidade;
            _desconto = Desconto;
        }
        
        public virtual double ValorEmEstoque ()
        {
            return _preco * _quantidade;
        }

        public double AplicarDesconto(double porcentagem){
            if (porcentagem != 0)
            {
                double precoAtual = Preco;
                double valor = precoAtual - (precoAtual * (porcentagem / 100));
                return valor;
            }
            return 0;
        }
        
        public override string ToString (){
            return "\nProduto"
            + "\nNome: " + _nome
            + "\nPreço: R$" + _preco
            + "\nQuantidade: " + _quantidade
            + "\nValor Em Estoque: R$" + ValorEmEstoque().ToString("F2")
            + (Desconto != 0 ? $"\nDesconto de {Desconto}%, R${AplicarDesconto(Desconto).ToString("F2")}" : "");
        }
    }
}