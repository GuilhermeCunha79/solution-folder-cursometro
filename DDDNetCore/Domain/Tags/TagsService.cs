using WebApplication1.Domain.Distrito;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Tags;

public class TagsService:ITagsService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITagsRepository _repo;

    public TagsService(IUnitOfWork unitOfWork, ITagsRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<TagsDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<TagsDTO> listDto = list.ConvertAll(tags =>
            new TagsDTO(tags.Id.IntValue,tags.NomeTags.NomeTag,tags.TagDescricao.Descricao));

        return listDto;
    }

    public async Task<TagsDTO> GetByIdAsync(Identifier id)
    {
        var tags = await _repo.GetByIdAsync(id);

        return new TagsDTO(tags.Id.IntValue,tags.NomeTags.NomeTag,tags.TagDescricao.Descricao);
    }
    

    public async Task<TagsDTO> AddAsync(TagsDTO dto)
    {
        var tags = new Tags(dto.Nome,dto.Descricao);

        await _repo.AddAsync(tags);

        await _unitOfWork.CommitAsync();

        return new TagsDTO(tags.Id.IntValue,tags.NomeTags.NomeTag,tags.TagDescricao.Descricao);
    }

    public async Task<TagsDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<TagsDTO> DeleteAsync(Identifier id)
    {
        var tags = await _repo.GetByIdAsync(id);

        if (tags == null)
            return null;

        _repo.Remove(tags);
        await _unitOfWork.CommitAsync();

        return new TagsDTO(tags.Id.IntValue,tags.NomeTags.NomeTag,tags.TagDescricao.Descricao);
    }

    public async Task<TagsDTO> UpdateAsync(TagsDTO dto)
    {
        var tags = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields
        

        await _unitOfWork.CommitAsync();

        return new TagsDTO(tags.Id.IntValue,tags.NomeTags.NomeTag,tags.TagDescricao.Descricao);
    }
}