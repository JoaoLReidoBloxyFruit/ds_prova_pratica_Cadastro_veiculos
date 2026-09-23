namespace GerenciadorVeiculos
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public Carro(string modelo, decimal precoBase, int quantidadePortas)
            : base(modelo, precoBase)
        {
            QuantidadePortas = quantidadePortas;
        }

        public override decimal CalcularValorSeguro()
        {
            decimal taxaPortas = QuantidadePortas * 50.00m;
            decimal taxaBase = PrecoBase * 0.03m;
            return taxaBase + taxaPortas;
        }
    }
}