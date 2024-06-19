using WebApplication1.Domain.Distrito;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Ranking;

public class InstituicaoRankingService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IInstituicaoRankingRepository _repo;

    public InstituicaoRankingService(IUnitOfWork unitOfWork, IInstituicaoRankingRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<Instituicao_RankingDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<Instituicao_RankingDTO> listDto = list.ConvertAll(instituicao =>
            new Instituicao_RankingDTO(instituicao.Id.IntValue, instituicao.IdRanking.IntValue,
                instituicao.InstituicaoCodigo.StringValue));

        return listDto;
    }

    public async Task<Instituicao_RankingDTO> GetByIdAsync(Identifier id)
    {
        var instituicao = await _repo.GetByIdAsync(id);

        return new Instituicao_RankingDTO(instituicao.Id.IntValue, instituicao.IdRanking.IntValue,
            instituicao.InstituicaoCodigo.StringValue);
    }

    public async Task<Instituicao_RankingDTO> AddAsync(Instituicao_RankingDTO dto)
    {
        var instituicao = new Instituicao_Ranking(dto.IdRanking, dto.CodigoInstituicao);

        await _repo.AddAsync(instituicao);

        await _unitOfWork.CommitAsync();

        return new Instituicao_RankingDTO(instituicao.Id.IntValue, instituicao.IdRanking.IntValue,
            instituicao.InstituicaoCodigo.StringValue);
    }

    public async Task<Instituicao_RankingDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<Instituicao_RankingDTO> DeleteAsync(Identifier id)
    {
        var instituicao = await _repo.GetByIdAsync(id);

        if (instituicao == null)
            return null;

        _repo.Remove(instituicao);
        await _unitOfWork.CommitAsync();

        return new Instituicao_RankingDTO(instituicao.Id.IntValue, instituicao.IdRanking.IntValue,
            instituicao.InstituicaoCodigo.StringValue);
    }

    public async Task<Instituicao_RankingDTO> UpdateAsync(Instituicao_RankingDTO dto)
    {
        var instituicao = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new Instituicao_RankingDTO(instituicao.Id.IntValue, instituicao.IdRanking.IntValue,
            instituicao.InstituicaoCodigo.StringValue);
    }
}