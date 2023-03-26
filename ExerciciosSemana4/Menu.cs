using drink;
using refrigerant;
using juice;


namespace ExerciciosSemana4;

public class Menu : Bebida
{
    public List<Bebida> Lista { get; set; }

    public Menu()
    {
        Lista = new List<Bebida>();
    }

    public static int MostrarMenu()
    {
        int op;
        try
        {
            Console.WriteLine("Menu das bebidas");
            Console.WriteLine("1 - Adicionar bebida");
            Console.WriteLine("2 - Alterar bebida");
            Console.WriteLine("3 - Remover bebida");
            Console.WriteLine("4 - Listar todas bebidas");
            Console.WriteLine("5 - Sair do menu");

            op = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Digite um número inteiro válido para escolher uma opção.");
            return MostrarMenu();
        }
        catch (OverflowException)
        {
            Console.WriteLine("O número digitado é muito grande ou muito pequeno para ser representado como um número inteiro.");
            return MostrarMenu();
        }

        return op;
    }
}
