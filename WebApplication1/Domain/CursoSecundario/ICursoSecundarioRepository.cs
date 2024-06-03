using WebApplication1.Domain.Curso;
using WebApplication1.Shared;

namespace ConsoleApp1.Domain.CursoSecundario;

public interface ICursoSecundarioRepository:IRepository<CursoSecundario,Identifier>
{
    Task<CursoSecundario> GetByCodCursoSec(Identifier codCurso);
}