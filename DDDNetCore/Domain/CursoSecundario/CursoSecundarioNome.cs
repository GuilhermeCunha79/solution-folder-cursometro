using WebApplication1.Shared;

namespace WebApplication1.Domain.CursoSecundario;

public class CursoSecundarioNome : IValueObject
{
    public string NomeCursoSecundario { get; set; }

    public CursoSecundarioNome()
    {
    }

    public CursoSecundarioNome(string nomeCursoSecundario)
    {
        NomeCursoSecundario = nomeCursoSecundario;
    }
}