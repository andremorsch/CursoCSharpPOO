namespace Aula51
{
    class Produto
    {
        private string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int qnt)
        {
            _name = nome;
            Price = preco;
            Quantity = qnt;

        }

        public string Nome
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{_name}, ${Price.ToString("F2")}, {Quantity} unidades, Total: ${TotalValueStock().ToString("F2")}";
        }

        public double TotalValueStock()
        {
            return Price * Quantity;
        }

        public void AddProdStock(int qnt)
        {
            Quantity += qnt;
        }

        public void RemoveProdStock(int qnt)
        {
            Quantity -= qnt;
        }
    }
}
