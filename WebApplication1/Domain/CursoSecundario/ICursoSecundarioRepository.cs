using WebApplication1.Shared;

namespace WebApplication1.Domain.CursoSecundario;

public interface ICursoSecundarioRepository:IRepository<CursoSecundario,Identifier>
{
    Task<CursoSecundario> GetByCodCursoSec(Identifier codCurso);
}