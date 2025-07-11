using ControleDeBar.ConsoleApp.Compartilhado;

namespace ControleDeBar.ConsoleApp.ModuloMesa;

public class Mesa : EntidadeBase<Mesa>
{
    public int Numero { get; set; }
    public int Capacidade { get; set; }
    public bool EstaOcupada { get; set; }

    public Mesa(int numero, int capacidade)
    {
        Numero = numero;
        Capacidade = capacidade;
        EstaOcupada = false;
    }

    public void Ocupar()
    {
        EstaOcupada = true;
    }

    public void Desocupar()
    {
        EstaOcupada = false;
    }


    public override void AtualizarRegistro(Mesa registroAtualizado)
    {
        Mesa mesaAtualizada = (Mesa)registroAtualizado;

        Numero = mesaAtualizada.Numero;
        Capacidade = mesaAtualizada.Capacidade;
    }

    public override string Validar()
    {
        string erros = string.Empty;

        if (Numero < 1)
            erros += "O campo \"N�mero\" deve conter um valor maior que 0.";

        if (Capacidade < 1)
            erros += "O campo \"Capacidade\" deve conter um valor maior que 0.";

        return erros;
    }
}