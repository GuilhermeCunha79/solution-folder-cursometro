using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_CursoCodigo : IValueObject
{
    public Identifier Codigo { get; set; }

    public Instituicao_CursoCodigo()
    {
    }

    public Instituicao_CursoCodigo(string codInstCurso)
    {
        Codigo = new Identifier(codInstCurso);
    }

    public Instituicao_CursoCodigo(string codigoInstituicao, string codigoCurso)
    {
        Codigo = new Identifier(codigoInstituicao + "/" + codigoCurso);
    }
}