using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso;

public interface ICursoRepository : IRepository<Curso, Identifier>
{

    Task<Curso> GetByCodigoCurso(string codigo);
    

}