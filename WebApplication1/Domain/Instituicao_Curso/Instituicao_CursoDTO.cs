namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_CursoDTO
{
    public Guid Id;
    public string CodigoInstituicao;
    public string CodigoCurso;
    public string Ects;
    public string Area;
    public string Duracao;
    public string Grau;
    public Guid IdCandidatura;
    public string CodigoExame;
    public byte[] Logo;

    public Instituicao_CursoDTO(Guid id, string codigoInstituicao, string codigoCurso, string ects, string area,
        string duracao, string grau, Guid idCandidatura, string codigoExame, byte[] logo)
    {
        Id = id;
        CodigoInstituicao = codigoInstituicao;
        CodigoCurso = codigoCurso;
        Ects = ects;
        Area = area;
        Duracao = duracao;
        Grau = grau;
        IdCandidatura = idCandidatura;
        CodigoExame = codigoExame;
        Logo = logo;
    }
}