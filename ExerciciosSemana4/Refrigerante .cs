
using drink;




namespace refrigerant
{
    public class Refrigerante : Bebida
{
    public bool Vidro { get; set; }

    public Refrigerante(int id, string tipo, string refrigerante, string suco, decimal miliLitro, string nomeBebida, decimal valorCompra, bool vidro)
        : base(id, tipo, refrigerante, suco, miliLitro, nomeBebida, valorCompra)
    {
        Vidro = vidro;
    }

    public void ImprimirDados()
    {
        string tipoEmbalagem = Vidro ? "vidro" : "é uma garrafa de plastico";
        Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante MiliLitros {MiliLitro} é {tipoEmbalagem}");
    }
}

}