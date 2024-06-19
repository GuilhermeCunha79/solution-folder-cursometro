using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Ranking;

public interface IInstituicaoRankingService
{
    Task<List<Instituicao_RankingDTO>> GetAllAsync();
    Task<Instituicao_RankingDTO> GetByIdAsync(Identifier id);
    Task<Instituicao_RankingDTO> AddAsync(Instituicao_RankingDTO dto);
    Task<Instituicao_RankingDTO> InactivateAsync(Identifier id);
    Task<Instituicao_RankingDTO> DeleteAsync(Identifier id);
    Task<Instituicao_RankingDTO> UpdateAsync(Instituicao_RankingDTO dto);
}