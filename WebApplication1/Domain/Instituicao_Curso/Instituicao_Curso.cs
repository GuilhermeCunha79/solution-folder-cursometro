using WebApplication1.Domain.Curso;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_Curso: Entity<Identifier>
{
    //pk, junção de duas fk
    public InstituicaoCodigo InstituicaoCodigo;
    public CursoCodigo CursoCodigo;
    //Instituicao_Curso
    public Instituicao_CursoECTS InstituicaoCursoEcts;
    public Instituicao_CursoDuracao InstituicaoCursoDuracao;
    public Instituicao_CursoGrau InstituicaoCursoGrau;
    //atributos estrangeiros
 
    
    


}