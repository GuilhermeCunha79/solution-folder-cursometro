using WebApplication1.Shared;

namespace WebApplication1.Domain.Ranking;

public interface IRankingService
{
    Task<List<RankingDTO>> GetAllAsync();
    Task<RankingDTO> GetByIdAsync(Identifier id);
    Task<RankingDTO> AddAsync(RankingDTO dto);
    Task<RankingDTO> InactivateAsync(Identifier id);
    Task<RankingDTO> DeleteAsync(Identifier id);
    Task<RankingDTO> UpdateAsync(RankingDTO dto);
}