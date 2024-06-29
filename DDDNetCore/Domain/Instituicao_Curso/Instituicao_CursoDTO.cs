namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_CursoDTO
{
    public string Id;
    public string CodigoInstituicao;
    public string CodigoCurso;
    public string Ects;
    public string Area;
    public string Duracao;
    public string Grau;

    public Instituicao_CursoDTO(string id, string codigoInstituicao, string ects, string area,
        string duracao, string grau)
    {
        Id = id;
        CodigoInstituicao = codigoInstituicao;
        Ects = ects;
        Area = area;
        Duracao = duracao;
        Grau = grau;
    }
}