namespace WebApplication1.Domain.Cif;

public class CifDTO
{
    public int Id;
    public int CifDisciplina;
    public int UtilizadorId;
    public string DisciplinaId;

    public CifDTO(int id,int cifDisciplina, int utilizadorId, string disciplinaId)
    {
        Id = id;
        CifDisciplina = cifDisciplina;
        UtilizadorId = utilizadorId;
        DisciplinaId = disciplinaId;
    }
}