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

        List<EscolaDTO> listDto = list.ConvertAll(escola =>
            new EscolaDTO(escola.Id.IntValue, escola.DistritoId.StringValue, escola.EscolaNome.NomeEscola));

        return listDto;
    }

    public async Task<EscolaDTO> GetByIdAsync(Identifier id)
    {
        var escola = await _repo.GetByIdAsync(id);

        return new EscolaDTO(escola.Id.IntValue, escola.DistritoId.StringValue, escola.EscolaNome.NomeEscola);
    }

    public async Task<List<EscolaDTO>> GetByDistrito(string nome)
    {
        var escolaList = await _repo.GetByDistrito(nome);

        List<EscolaDTO> list = escolaList.ConvertAll(escola =>
            new EscolaDTO(escola.Id.IntValue, escola.DistritoId.StringValue, escola.EscolaNome.NomeEscola));

        return list;
    }

    public async Task<EscolaDTO> AddAsync(EscolaDTO dto)
    {
        var escola = new Escola(dto.Id, dto.NomeEscola, dto.IdDistrito);

        await _repo.AddAsync(escola);

        await _unitOfWork.CommitAsync();

        return new EscolaDTO(escola.Id.IntValue, escola.DistritoId.StringValue, escola.EscolaNome.NomeEscola);
    }

    public async Task<EscolaDTO> InactivateAsync(Identifier id)
    {
        var escola = await _repo.GetByIdAsync(id);

        if (escola == null)
            return null;

        escola.MarkAsInactive();

        await _unitOfWork.CommitAsync();

        return new EscolaDTO(escola.Id.IntValue, escola.DistritoId.StringValue, escola.EscolaNome.NomeEscola);
    }

    public async Task<EscolaDTO> DeleteAsync(Identifier id)
    {
        var escola = await _repo.GetByIdAsync(id);

        if (escola == null)
            return null;

        _repo.Remove(escola);
        await _unitOfWork.CommitAsync();

        return new EscolaDTO(escola.Id.IntValue, escola.DistritoId.StringValue, escola.EscolaNome.NomeEscola);
    }

    public async Task<EscolaDTO> UpdateAsync(EscolaDTO dto)
    {
        var escola = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields

        await _unitOfWork.CommitAsync();

        return new EscolaDTO(escola.Id.IntValue, escola.DistritoId.StringValue, escola.EscolaNome.NomeEscola);
    }
}