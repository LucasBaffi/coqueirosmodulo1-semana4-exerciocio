using drink;


namespace juice
{
   public class Suco : Bebida
{
    public string TipoCaixa { get; set; }

    public Suco(int id, string tipo, string refrigerante, string suco, decimal miliLitro, string nomeBebida, decimal valorCompra, string tipoCaixa)
        : base(id, tipo, refrigerante, suco, miliLitro, nomeBebida, valorCompra)
    {
        TipoCaixa = tipoCaixa;
    }

    public void ImprimirDados()
    {
        Console.WriteLine($"O produto id {Id} é um suco é do tipo {TipoCaixa} com quantidade de MiliLitros {MiliLitro}");
    }
}

}