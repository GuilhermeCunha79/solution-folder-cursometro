using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador_ExameIngresso;

public class Utilizador_ExameIngressoNotaExame:IValueObject
{
    public string NotaExameIngresso { get; set; }

    public Utilizador_ExameIngressoNotaExame()
    {
    }

    public Utilizador_ExameIngressoNotaExame(string nota)
    {
        NotaExameIngresso = nota;
    }
}