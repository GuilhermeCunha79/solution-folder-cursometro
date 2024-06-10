using WebApplication1.Shared;

namespace WebApplication1.Domain.Cif;

public interface ICifService
{
    Task<List<CifDTO>> GetAllAsync();
    Task<CifDTO> GetByIdAsync(Identifier id);
    Task<List<CifDTO>> GetByUtilizadorId(Identifier utilizadorId);
    Task<CifDTO> GetByUtilizadorDisciplina(int utilizadorId, string disciplinaId);
    Task<CifDTO> AddAsync(CifDTO dto);
    Task<CifDTO> UpdateByUtilizadorDisciplinaIdAsync(CifDTO dto);
    Task<CifDTO> DeleteAsync(Identifier id);
    Task<CifDTO> UpdateAsync(CifDTO dto);
}