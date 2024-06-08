namespace exercicioTP2
{
    public class ProdutoPerecivel : Produto
    {
        private DateTime _dataDeValidade;
        public DateTime DataDeValidade { get{ return _dataDeValidade; } set{ _dataDeValidade = value; } }

        public ProdutoPerecivel(){}
        public ProdutoPerecivel (string nome, double preco, int quantidade, DateTime dateTime) : base(nome, preco, quantidade)
        {
            _dataDeValidade = dateTime;
        }
        
        public override double ValorEmEstoque () {
            double valorEstoque = base.ValorEmEstoque();
            if (_dataDeValidade < DateTime.Now.AddDays(7)) {
                valorEstoque *= 0.8;
            }
            return valorEstoque;
        }

        public override string ToString (){
            return "\nProduto"
            + "\nNome: " + Nome
            + "\nPreço: " + Preco
            + "\nQuantidade: " + Quantidade
            + "\nValor Em Estoque: " + ValorEmEstoque().ToString("F2")
            + "\nData de Validade: " + DataDeValidade;
        }
    }
}