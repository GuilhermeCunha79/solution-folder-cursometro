namespace WebApplication1.Domain.Instituicao_Curso_ExameIngresso;

public class Instituicao_Curso_ExameIngressoDTO
{
    public int Id;
    public string InstituicaoCursoCodigo;
    public string CodigoExame;

    public Instituicao_Curso_ExameIngressoDTO(int id, string instituicaoCursoCodigo, string codigoExame)
    {
        Id = id;
        InstituicaoCursoCodigo = instituicaoCursoCodigo;
        CodigoExame = codigoExame;
    }
}