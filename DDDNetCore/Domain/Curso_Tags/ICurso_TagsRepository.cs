using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso_Tags;

public interface ICurso_TagsRepository:IRepository<Curso_Tags,Identifier>
{
    Task<List<Curso_Tags>> GetByCursoCodigoTagId(string codigo, Identifier tagId);
}