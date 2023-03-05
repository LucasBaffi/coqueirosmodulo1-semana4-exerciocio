
using drink;
using juice;
using refrigerant;

namespace ExercicioSemana4
{
    public class Repositorio
    {
        private static List<Bebida> ListaBebida = new List<Bebida>();
        private static List<Suco> ListaSuco = new List<Suco>();
        private static List<Refrigerante> ListaRefrigerante = new List<Refrigerante>();

        public static void AdicionarSuco(Suco suco)
        {
            ListaBebida.Add(suco);
            ListaSuco.Add(suco);
        }

        public static void AdicionarRefrigerante(Refrigerante refrigerante)
        {
            ListaBebida.Add(refrigerante);
            ListaRefrigerante.Add(refrigerante);
        }

        public static void AdicionarBebida(Bebida bebida)
        {
            ListaBebida.Add(bebida);
        }

        public static void AlterarBebida(Bebida bebida)
        {
            var index = ListaBebida.FindIndex(b => b.Id == bebida.Id);
            if (index != -1)
            {
                ListaBebida[index] = bebida;
            }
            else
            {
                Console.WriteLine("Bebida não encontrada");
            }
        }

        public static void ExcluirBebida(int id)
        {
            var bebida = ListaBebida.FirstOrDefault(b => b.Id == id);
            if (bebida != null)
            {
                ListaBebida.Remove(bebida);
            }
            else
            {
                Console.WriteLine("Bebida não encontrada");
            }
        }

        public static List<Bebida> ListarBebidas()
        {
            return ListaBebida;
        }

        public static void ImprimirRefrigerantes()
        {
            foreach (var refrigerante in ListaRefrigerante)
            {
                refrigerante.ImprimirDados();
            }
        }
    }
}

