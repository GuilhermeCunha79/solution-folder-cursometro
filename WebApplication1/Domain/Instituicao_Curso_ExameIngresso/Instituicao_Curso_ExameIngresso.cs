using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Insituicao_Curso_ExameIngresso;

public class Instituicao_Curso_ExameIngresso : Entity<Identifier>
{
    public Identifier ExameIngressoCodigo { get; set; }
    public Identifier InstituicaoCursoCodigo { get; set; }
    public Instituicao_Curso.Instituicao_Curso InstituicaoCurso { get; set; }

    public ExameIngresso.ExameIngresso ExameIngresso { get; set; }

    public Instituicao_Curso_ExameIngresso()
    {
        
    }

    public Instituicao_Curso_ExameIngresso(string codigoInstituicao, string codigoExame)
    {
        InstituicaoCursoCodigo = new Instituicao_CursoCodigo(codigoInstituicao).Codigo;
        ExameIngressoCodigo = new ExameIngressoCodigo(codigoExame).CodigoExameIngresso;
        
    }
}