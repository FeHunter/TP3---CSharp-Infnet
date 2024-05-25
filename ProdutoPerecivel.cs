namespace exercicioTP2
{
    public class ProdutoPerecivel : Produto
    {
        private DateTime _dataDeValidade;
        public DateTime DataDeValidade { get{ return _dataDeValidade; } set{ _dataDeValidade = value; } }
        
        public override double ValorEmEstoque () {
            if (_dataDeValidade >= DateTime.Now)
            {
                return Preco * Quantidade / 100 * 20;
            }
            else
            {
                return Preco * Quantidade;
            }
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