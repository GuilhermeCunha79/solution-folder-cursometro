using WebApplication1.Shared;

namespace WebApplication1.Domain.Distrito;

public class DistritoService : IDistritoService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDistritoRepository _repo;

    public DistritoService(IUnitOfWork unitOfWork, IDistritoRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<DistritoDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<DistritoDTO> listDto = list.ConvertAll(distrito =>
            new DistritoDTO(distrito.Id.StringValue, distrito.DistritoNome.NomeDistrito));

        return listDto;
    }

    public async Task<DistritoDTO> GetByIdAsync(Identifier id)
    {
        var distrito = await _repo.GetByIdAsync(id);

        return new DistritoDTO(distrito.Id.StringValue, distrito.DistritoNome.NomeDistrito);
    }

    public async Task<DistritoDTO> AddAsync(DistritoDTO dto)
    {
        var distrito = new Distrito(dto.Id, dto.Distrito);

        await _repo.AddAsync(distrito);

        await _unitOfWork.CommitAsync();

        return new DistritoDTO(distrito.Id.StringValue, distrito.DistritoNome.NomeDistrito);
    }

    public async Task<DistritoDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<DistritoDTO> DeleteAsync(Identifier id)
    {
        var distrito = await _repo.GetByIdAsync(id);

        if (distrito == null)
            return null;

        _repo.Remove(distrito);
        await _unitOfWork.CommitAsync();

        return new DistritoDTO(distrito.Id.StringValue, distrito.DistritoNome.NomeDistrito);
    }

    public async Task<DistritoDTO> UpdateAsync(DistritoDTO dto)
    {
        throw new NotImplementedException();
    }
}