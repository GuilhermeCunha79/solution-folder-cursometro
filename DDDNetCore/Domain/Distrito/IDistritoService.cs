using WebApplication1.Shared;

namespace WebApplication1.Domain.Distrito;

public interface IDistritoService
{
    Task<List<DistritoDTO>> GetAllAsync();
    Task<DistritoDTO> GetByIdAsync(Identifier id);
    Task<DistritoDTO> AddAsync(DistritoDTO dto);
    Task<DistritoDTO> InactivateAsync(Identifier id);
    Task<DistritoDTO> DeleteAsync(Identifier id);
    Task<DistritoDTO> UpdateAsync(DistritoDTO dto);
}