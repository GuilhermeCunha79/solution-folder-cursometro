using WebApplication1.Shared;

namespace WebApplication1.Domain.ExameIngresso;

public interface IExameIngressoService
{
    Task<List<ExameIngressoDTO>> GetAllAsync();
    Task<ExameIngressoDTO> GetByIdAsync(Identifier id);
    Task<ExameIngressoDTO> AddAsync(ExameIngressoDTO dto);
    Task<ExameIngressoDTO> InactivateAsync(Identifier id);
    Task<ExameIngressoDTO> DeleteAsync(Identifier id);
    Task<ExameIngressoDTO> UpdateAsync(ExameIngressoDTO dto);
}