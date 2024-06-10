using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public interface ICandidaturaService
{
    Task<List<CandidaturaDTO>> GetAllAsync();
    Task<CandidaturaDTO> GetByIdAsync(Identifier id);
    Task<CandidaturaDTO> AddAsync(CandidaturaDTO dto);
    Task<CandidaturaDTO> InactivateAsync(Identifier id);
    Task<CandidaturaDTO> DeleteAsync(Identifier id);
    Task<CandidaturaDTO> UpdateAsync(CandidaturaDTO dto);
}