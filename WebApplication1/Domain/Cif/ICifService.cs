using WebApplication1.Shared;

namespace WebApplication1.Domain.Cif;

public interface ICifService
{
    Task<List<CifDTO>> GetAllAsync();
    Task<CifDTO> GetByIdAsync(Identifier id);
    Task<CifDTO> GetByUtilizadorId(Identifier utilizadorId);
    Task<CifDTO> AddAsync(CifDTO dto);
}