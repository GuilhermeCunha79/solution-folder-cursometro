using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso;

public class CursoCodigo : IValueObject
{
    public string Codigo { get; set; }

    public CursoCodigo()
    {
    }

    public CursoCodigo(string codigo)
    {
        Codigo = codigo;
    }
}