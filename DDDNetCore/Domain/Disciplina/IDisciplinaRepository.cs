using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina;

public interface IDisciplinaRepository:IRepository<Disciplina,Identifier>
{
    Task<Disciplina> GetByDisciplinaId(string identifier);
}