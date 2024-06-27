using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador;

public interface IUtilizadorService
{
    Task<List<UtilizadorDTO>> GetAllAsync();
    Task<UtilizadorDTO> GetByIdAsync(Identifier id);
    Task<UtilizadorDTO> AddAsync(UtilizadorDTO dto);
    Task<UtilizadorDTO> InactivateAsync(Identifier id);
    Task<UtilizadorDTO> DeleteAsync(Identifier id);
    Task<UtilizadorDTO> UpdateAsync(UtilizadorDTO dto);
}