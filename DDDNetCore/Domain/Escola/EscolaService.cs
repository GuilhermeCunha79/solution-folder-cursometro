using WebApplication1.Shared;

namespace WebApplication1.Domain.Escola;

public class EscolaService : IEscolaService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IEscolaRepository _repo;

    public EscolaService(IUnitOfWork unitOfWork, IEscolaRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<EscolaDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<EscolaDTO> listDto = list.ConvertAll(distrito =>
            new EscolaDTO(distrito.Id.IntValue, distrito.Distrito.Id.StringValue, distrito.EscolaNome.NomeEscola));

        return listDto;
    }

    public async Task<EscolaDTO> GetByIdAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<EscolaDTO>> GetByDistrito(string nome)
    {
        throw new NotImplementedException();
    }

    public async Task<EscolaDTO> AddAsync(EscolaDTO dto)
    {
        throw new NotImplementedException();
    }

    public async Task<EscolaDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<EscolaDTO> DeleteAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<EscolaDTO> UpdateAsync(EscolaDTO dto)
    {
        throw new NotImplementedException();
    }
}