using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador_ExameIngresso;

public class Utilizador_ExameIngressoNotaExame:IValueObject
{
    public int NotaExameIngresso { get; set; }

    public Utilizador_ExameIngressoNotaExame()
    {
    }

    public Utilizador_ExameIngressoNotaExame(int nota)
    {
        NotaExameIngresso = nota;
    }
}