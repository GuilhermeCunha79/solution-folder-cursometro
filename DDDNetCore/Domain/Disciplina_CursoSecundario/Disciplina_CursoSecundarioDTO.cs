namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundarioDTO
{
    public int Idd;
    public string DisciplinaCodigo;
    public int CodigoCursoSecundario;
    public int UtilizadorId;
    public string NotaDecimo;
    public string NotaDecimoPrim;
    public string NotaDecimoSeg;

    public Disciplina_CursoSecundarioDTO(int id, int utilizadorId,string codigoDisciplina, int codigoCursoSecundario,
        string notaDecimo,string notaDecimoPrim,string notaDecimoSeg)
    {
        Idd = id;
        UtilizadorId = utilizadorId;
        DisciplinaCodigo = codigoDisciplina;
        CodigoCursoSecundario = codigoCursoSecundario;
        NotaDecimo = notaDecimo;
        NotaDecimoPrim = notaDecimoPrim;
        NotaDecimoSeg = notaDecimoSeg;
    }
}