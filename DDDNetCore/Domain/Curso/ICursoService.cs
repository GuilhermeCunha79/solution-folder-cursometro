using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso;

public interface ICursoService
{
    Task<List<CursoDTO>> GetAllAsync();
    Task<CursoDTO> GetByCursoCodigo(string codigo);
    Task<CursoDTO> GetByIdAsync(Identifier id);
    Task<CursoDTO> AddAsync(CursoDTO dto);
}