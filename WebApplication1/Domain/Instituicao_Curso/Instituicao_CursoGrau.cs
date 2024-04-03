using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_CursoGrau : IValueObject
{
    private string Grau { get; set; }

    public Instituicao_CursoGrau()
    {
        
    }
    
    public Instituicao_CursoGrau(string grau)
    {
        Grau = grau;
    }
}