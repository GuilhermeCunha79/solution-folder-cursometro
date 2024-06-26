using WebApplication1.Domain.Distrito;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Tags;

public class Instituicao_TagsService : IInstituicao_TagsService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IInstituicao_TagsRepository _repo;

    public Instituicao_TagsService(IUnitOfWork unitOfWork, IInstituicao_TagsRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<Instituicao_TagsDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<Instituicao_TagsDTO> listDto = list.ConvertAll(instituicao =>
            new Instituicao_TagsDTO(instituicao.Id.IntValue, instituicao.TagId.IntValue,
                instituicao.InstituicaoCodigo.StringValue));

        return listDto;
    }

    public async Task<Instituicao_TagsDTO> GetByIdAsync(Identifier id)
    {
        var instituicao = await _repo.GetByIdAsync(id);

        return new Instituicao_TagsDTO(instituicao.Id.IntValue, instituicao.TagId.IntValue,
            instituicao.InstituicaoCodigo.StringValue);
    }

    public async Task<Instituicao_TagsDTO> AddAsync(Instituicao_TagsDTO dto)
    {
        var instituicao = new Instituicao_Tags(dto.Id, dto.CodigoInstituicao);

        await _repo.AddAsync(instituicao);

        await _unitOfWork.CommitAsync();

        return new Instituicao_TagsDTO(instituicao.Id.IntValue, instituicao.TagId.IntValue,
            instituicao.InstituicaoCodigo.StringValue);
    }

    public async Task<Instituicao_TagsDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<Instituicao_TagsDTO> DeleteAsync(Identifier id)
    {
        var instituicao = await _repo.GetByIdAsync(id);

        if (instituicao == null)
            return null;

        _repo.Remove(instituicao);
        await _unitOfWork.CommitAsync();

        return new Instituicao_TagsDTO(instituicao.Id.IntValue, instituicao.TagId.IntValue,
            instituicao.InstituicaoCodigo.StringValue);
    }

    public async Task<Instituicao_TagsDTO> UpdateAsync(Instituicao_TagsDTO dto)
    {
        var instituicao = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new Instituicao_TagsDTO(instituicao.Id.IntValue, instituicao.TagId.IntValue,
            instituicao.InstituicaoCodigo.StringValue);
    }
}