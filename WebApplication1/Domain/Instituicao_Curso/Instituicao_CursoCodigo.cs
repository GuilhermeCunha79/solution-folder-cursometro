using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_CursoCodigo : IValueObject
{
    private string Codigo { get; set; }

    public Instituicao_CursoCodigo()
    {
    }

    public Instituicao_CursoCodigo(string codigo)
    {
        Codigo = codigo;
    }
}