using WebApplication1.Shared;

namespace WebApplication1.Domain.CursoSecundario;

public interface ICursoSecundarioService
{
    Task<CursoSecundarioDTO> GetByIdAsync(Identifier id);
    Task<List<CursoSecundarioDTO>> GetAllAsync();
    Task<CursoSecundarioDTO> GetByCursoCodigoSec(Identifier codigo);
    Task<CursoSecundarioDTO> AddAsync(CursoSecundarioDTO dto);
}