using WebApplication1.Shared;

namespace WebApplication1.Domain.Escola;

public interface IEscolaService
{
    Task<List<EscolaDTO>> GetAllAsync();
    Task<EscolaDTO> GetByIdAsync(Identifier id);
    Task<List<EscolaDTO>> GetByDistrito(string nome);
    Task<EscolaDTO> AddAsync(EscolaDTO dto);
    Task<EscolaDTO> InactivateAsync(Identifier id);
    Task<EscolaDTO> DeleteAsync(Identifier id);
    Task<EscolaDTO> UpdateAsync(EscolaDTO dto);
}