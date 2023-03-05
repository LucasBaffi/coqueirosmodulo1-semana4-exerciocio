


namespace drink
{
   public class Bebida
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public string Refrigerante { get; set; }
    public string Suco { get; set; }
    public decimal MiliLitro { get; set; }
    public string NomeBebida { get; set; }
    public decimal ValorCompra { get; set; }

    public Bebida(int id, string tipo, string refrigerante, string suco, decimal miliLitro, string nomeBebida, decimal valorCompra)
    {
        Id = id;
        Tipo = tipo;
        Refrigerante = refrigerante;
        Suco = suco;
        MiliLitro = miliLitro;
        NomeBebida = nomeBebida;
        ValorCompra = valorCompra;
    }

    public void Comprar(decimal novoValor)
    {
        ValorCompra = novoValor;
        Console.WriteLine($"Valor da compra do produto id {Id} alterado para {ValorCompra}");
    }
}

}