using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Insituicao_Curso_ExameIngresso;

public class Instituicao_Curso_ExameIngresso : Entity<Identifier>
{
    public ExameIngressoCodigo ExameIngressoCodigo { get; set; }
    public Instituicao_CursoCodigo InstituicaoCursoCodigo { get; set; }
    public Instituicao_Curso.Instituicao_Curso InstituicaoCurso { get; set; }

    public ExameIngresso.ExameIngresso ExameIngresso { get; set; }

    public Instituicao_Curso_ExameIngresso()
    {
        
    }

    public Instituicao_Curso_ExameIngresso(string codigoInstituicao, string codigoExame)
    {
        Id = new Identifier(Guid.NewGuid());
        InstituicaoCursoCodigo = new Instituicao_CursoCodigo(codigoInstituicao);
        ExameIngressoCodigo = new ExameIngressoCodigo(codigoExame);
        
    }
}