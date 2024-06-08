using System;

namespace exercicioTP2
{
    public class Produto : IDescontavel
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        
        public  string Nome { get{ return _nome; } set { _nome = value; } }
        public double Preco { get{ return _preco; } set{ _preco = value; } }
        public int Quantidade { get{ return _quantidade; } set{ _quantidade = value; } }
        
        public Produto (){
        }
        public Produto (string Nome, double Preco, int Quantidade){
            _nome = Nome;
            _preco = Preco;
            _quantidade = Quantidade;
        }
        
        public virtual double ValorEmEstoque ()
        {
            return _preco * _quantidade;
        }
        
        public override string ToString (){
            return "\nProduto"
            + "\nNome: " + _nome
            + "\nPreço: " + _preco
            + "\nQuantidade: " + _quantidade
            + "\nValor Em Estoque: " + ValorEmEstoque();
        }

        public void AplicarDesconto(double porcentagem){}
    }
}