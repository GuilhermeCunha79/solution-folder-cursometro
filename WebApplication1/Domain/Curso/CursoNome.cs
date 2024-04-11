using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso;

public class CursoNome : IValueObject
{
    public string Nome { get; set; }

    public CursoNome()
    {
    }

    public CursoNome(string nome)
    {
        Nome = nome;
    }
}