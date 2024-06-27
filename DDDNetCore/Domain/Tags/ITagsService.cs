using WebApplication1.Shared;

namespace WebApplication1.Domain.Tags;

public interface ITagsService
{
    Task<List<TagsDTO>> GetAllAsync();
    Task<TagsDTO> GetByIdAsync(Identifier id);
    Task<TagsDTO> AddAsync(TagsDTO dto);
    Task<TagsDTO> InactivateAsync(Identifier id);
    Task<TagsDTO> DeleteAsync(Identifier id);
    Task<TagsDTO> UpdateAsync(TagsDTO dto);
}