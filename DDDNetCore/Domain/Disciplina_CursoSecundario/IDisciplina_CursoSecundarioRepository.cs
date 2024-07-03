using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public interface IDisciplina_CursoSecundarioRepository:IRepository<Disciplina_CursoSecundario,Identifier>
{
    Task<List<Disciplina_CursoSecundario>> GetByUtilizadorId(string utilizadorId);
    Task<Disciplina_CursoSecundario> GetByUtilizadorDisciplina(int utilizadorId, string disciplinaCod);

}