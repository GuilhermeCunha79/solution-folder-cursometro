using WebApplication1.Infrastructure;
using WebApplication1.Shared;

namespace WebApplication1.Domain.ExameIngresso;

public class ExameIngressoService : IExameIngressoService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IExameIngressoRepository _repo;

    public ExameIngressoService(IUnitOfWork unitOfWork, IExameIngressoRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<ExameIngressoDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<ExameIngressoDTO> listDto = list.ConvertAll(exame =>
            new ExameIngressoDTO(exame.Id.StringValue, exame.ExameIngressoNome.NomeExameIngresso));

        return listDto;
    }

    public async Task<ExameIngressoDTO> GetByIdAsync(Identifier id)
    {
        var exame = await _repo.GetByIdAsync(id);

        return new ExameIngressoDTO(exame.Id.StringValue, exame.ExameIngressoNome.NomeExameIngresso);
    }

    public async Task<ExameIngressoDTO> AddAsync(ExameIngressoDTO dto)
    {
        var exame = new ExameIngresso(dto.CodigoExame, dto.NomeExame);

        await _repo.AddAsync(exame);

        await _unitOfWork.CommitAsync();

        return new ExameIngressoDTO(exame.Id.StringValue, exame.ExameIngressoNome.NomeExameIngresso);
    }

    public async Task<ExameIngressoDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<ExameIngressoDTO> DeleteAsync(Identifier id)
    {
        var exame = await _repo.GetByIdAsync(id);

        if (exame == null)
            return null;

        _repo.Remove(exame);
        await _unitOfWork.CommitAsync();

        return new ExameIngressoDTO(exame.Id.StringValue, exame.ExameIngressoNome.NomeExameIngresso);
    }

    public async Task<ExameIngressoDTO> UpdateAsync(ExameIngressoDTO dto)
    {
        var exame = await _repo.GetByIdAsync(new Identifier(dto.CodigoExame));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new ExameIngressoDTO(exame.Id.StringValue, exame.ExameIngressoNome.NomeExameIngresso);
    }
}