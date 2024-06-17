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

    public Instituicao_CursoDTO(string id, string codigoInstituicao, string codigoCurso, string ects, string area,
        string duracao, string grau)
    {
        Id = id;
        CodigoInstituicao = codigoInstituicao;
        CodigoCurso = codigoCurso;
        Ects = ects;
        Area = area;
        Duracao = duracao;
        Grau = grau;
    }
}