using ControleDeBar.ConsoleApp.Compartilhado;

namespace ControleDeBar.ConsoleApp.ModuloMesa;

public class TelaMesa : TelaBase<Mesa>, ITela
{
    public TelaMesa(RepositorioMesa repositorioMesa) : base("Mesa", repositorioMesa)
    {
    }

    public override void VisualizarRegistros(bool exibirCabecalho)
    {
        if (exibirCabecalho)
            ExibirCabecalho();

        Console.WriteLine("Visualiza��o de Mesas");

        Console.WriteLine();

        Console.WriteLine(
            "{0, -10} | {1, -30} | {2, -30}",
            "Id", "N�mero", "Capacidade", "Status"
        );

        Mesa[] mesas = repositorio.SelecionarRegistros();

        for (int i = 0; i < mesas.Length; i++)
        {
            Mesa m = mesas[i];

            if (m == null)
                continue;

            string statusMesa = m.EstaOcupada ? "Ocupada" : "Dispon�vel";

            Console.WriteLine(
              "{0, -10} | {1, -30} | {2, -30}",
                m.Id, m.Numero, m.Capacidade, statusMesa
            );
        }

        ApresentarMensagem("Digite ENTER para continuar...", ConsoleColor.DarkYellow);
    }

    protected override Mesa ObterDados()
    {
        bool conseguiuConverterNumero = false;

        int numero = 0;

        while (!conseguiuConverterNumero)
        {
            Console.Write("Digite o n�mero da mesa: ");
            conseguiuConverterNumero = int.TryParse(Console.ReadLine(), out numero);

            if (!conseguiuConverterNumero)
            {
                ApresentarMensagem("Digite um n�mero v�lido!", ConsoleColor.DarkYellow);
                Console.Clear();
            }
        }

        bool conseguiuConverterCapacidade = false;

        int capacidade = 0;

        while (!conseguiuConverterCapacidade)
        {
            Console.Write("Digite a capacidade da mesa: ");
            conseguiuConverterCapacidade = int.TryParse(Console.ReadLine(), out capacidade);

            if (!conseguiuConverterNumero)
            {
                ApresentarMensagem("Digite um n�mero v�lido!", ConsoleColor.DarkYellow);
                Console.Clear();
            }
        }

        return new Mesa(numero, capacidade);
    }
}