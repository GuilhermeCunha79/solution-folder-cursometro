using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_CursoDuracao : IValueObject
{
    public string Duracao { get; set; }

    public Instituicao_CursoDuracao()
    {
    }

    public Instituicao_CursoDuracao(string duracao)
    {
        Duracao = duracao;
    }
}