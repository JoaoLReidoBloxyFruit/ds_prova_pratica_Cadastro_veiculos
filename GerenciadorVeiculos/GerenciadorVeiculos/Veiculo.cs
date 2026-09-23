namespace GerenciadorVeiculos
{
    public abstract class Veiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public decimal PrecoBase { get; set; }

        protected Veiculo(string modelo, decimal precoBase)
        {
            Modelo = modelo;
            PrecoBase = precoBase;
        }

        public abstract decimal CalcularValorSeguro();
    }
}