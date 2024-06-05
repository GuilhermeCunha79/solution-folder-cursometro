using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public class CandidaturaService: ICandidaturaService
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly ICandidaturaRepository _repo;

    public CandidaturaService(IUnitOfWork unitOfWork, ICandidaturaRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<CandidaturaDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<CandidaturaDTO> listDto =
            list.ConvertAll(candidatura => new CandidaturaDTO(candidatura.Id.IntValue,
                candidatura.Instituicao_CursoCodigo.StringValue,candidatura.CandidaturaAno.Ano,candidatura.CandidaturaFase.Fase));

        return listDto;
    }

    public async Task<CandidaturaDTO> GetByIdAsync(Identifier id)
    {
        var candidatura = await _repo.GetByIdAsync(id);
        
        return new CandidaturaDTO(candidatura.Id.IntValue,
            candidatura.Instituicao_CursoCodigo.StringValue,candidatura.CandidaturaAno.Ano,candidatura.CandidaturaFase.Fase);
    }
    

    public async Task<CandidaturaDTO> AddAsync(CandidaturaDTO dto)
    {
        var candidatura = new Candidatura(dto.InstituicaoCursoCodigo,dto.Ano,dto.Fase);

        await _repo.AddAsync(candidatura);

        await _unitOfWork.CommitAsync();

        return new CandidaturaDTO(candidatura.Id.IntValue,
            candidatura.Instituicao_CursoCodigo.StringValue,candidatura.CandidaturaAno.Ano,candidatura.CandidaturaFase.Fase);
    }
}