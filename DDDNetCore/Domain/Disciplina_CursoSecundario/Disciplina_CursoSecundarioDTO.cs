namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundarioDTO
{
    public string Id;
    public string DisciplinaCodigo;
    public int CodigoCursoSecundario;
    public int UtilizadorId;
    public string NotaDecimo;
    public string NotaDecimoPrim;
    public string NotaDecimoSeg;
    public int CifDisciplina;
    public string NotaExameInterno1;
    public string NotaExameInterno2;
    public string NotaExameExterno1;
    public string NotaExameExterno2;
    public bool IsIngresso;

    public Disciplina_CursoSecundarioDTO(string id, int utilizadorId, string codigoDisciplina,
        int codigoCursoSecundario,
        string notaDecimo, string notaDecimoPrim, string notaDecimoSeg, int cifDisciplina, string notaExameInterno1,
        string notaExameInterno2, string notaExameExterno1, string notaExameExterno2, bool isIngresso)
    {
        Id = id;
        UtilizadorId = utilizadorId;
        DisciplinaCodigo = codigoDisciplina;
        CodigoCursoSecundario = codigoCursoSecundario;
        NotaDecimo = notaDecimo;
        NotaDecimoPrim = notaDecimoPrim;
        NotaDecimoSeg = notaDecimoSeg;
        CifDisciplina = cifDisciplina;
        NotaExameInterno1 = notaExameInterno1;
        NotaExameInterno2 = notaExameInterno2;
        NotaExameExterno1 = notaExameExterno1;
        NotaExameExterno2 = notaExameExterno2;
        IsIngresso = isIngresso;
    }
}