using WebApplication1.Shared;

namespace WebApplication1.Domain.Ranking;

public class RankingService : IRankingService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRankingRepository _repo;

    public RankingService(IUnitOfWork unitOfWork, IRankingRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<RankingDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<RankingDTO> listDto = list.ConvertAll(ranking =>
            new RankingDTO(ranking.Id.IntValue, ranking.RankingNome.NomeRanking, ranking.Posicao.PosicaoRanking,
                ranking.RankingNacional.BoolRanking));

        return listDto;
    }

    public async Task<RankingDTO> GetByIdAsync(Identifier id)
    {
        var ranking = await _repo.GetByIdAsync(id);

        return new RankingDTO(ranking.Id.IntValue, ranking.RankingNome.NomeRanking, ranking.Posicao.PosicaoRanking,
            ranking.RankingNacional.BoolRanking);
    }

    public async Task<RankingDTO> AddAsync(RankingDTO dto)
    {
        var ranking = new Ranking(dto.Id, dto.NomeRanking, dto.Posicao, dto.NacionalBool);

        await _repo.AddAsync(ranking);

        await _unitOfWork.CommitAsync();

        return new RankingDTO(ranking.Id.IntValue, ranking.RankingNome.NomeRanking, ranking.Posicao.PosicaoRanking,
            ranking.RankingNacional.BoolRanking);
    }

    public async Task<RankingDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<RankingDTO> DeleteAsync(Identifier id)
    {
        var ranking = await _repo.GetByIdAsync(id);

        if (ranking == null)
            return null;

        _repo.Remove(ranking);
        await _unitOfWork.CommitAsync();

        return new RankingDTO(ranking.Id.IntValue, ranking.RankingNome.NomeRanking, ranking.Posicao.PosicaoRanking,
            ranking.RankingNacional.BoolRanking);
    }

    public async Task<RankingDTO> UpdateAsync(RankingDTO dto)
    {
        var ranking = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new RankingDTO(ranking.Id.IntValue, ranking.RankingNome.NomeRanking, ranking.Posicao.PosicaoRanking,
            ranking.RankingNacional.BoolRanking);
    }
}