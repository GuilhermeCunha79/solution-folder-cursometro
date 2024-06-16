using WebApplication1.Shared;

namespace WebApplication1.Domain.InformacoesCandidatura;

public interface IInformacoesCandidaturaService
{
    Task<List<InformacoesCandidaturaDTO>> GetAllAsync();
    Task<InformacoesCandidaturaDTO> GetByIdAsync(Identifier id);
    Task<InformacoesCandidaturaDTO> GetByCandidaturaId(Identifier id);
    Task<InformacoesCandidaturaDTO> AddAsync(InformacoesCandidaturaDTO dto);
    Task<InformacoesCandidaturaDTO> InactivateAsync(Identifier id);
    Task<InformacoesCandidaturaDTO> DeleteAsync(Identifier id);
    Task<InformacoesCandidaturaDTO> UpdateAsync(InformacoesCandidaturaDTO dto);
}