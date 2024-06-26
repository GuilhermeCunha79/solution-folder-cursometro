using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Tags;

public interface IInstituicao_TagsService
{
    Task<List<Instituicao_TagsDTO>> GetAllAsync();
    Task<Instituicao_TagsDTO> GetByIdAsync(Identifier id);
    Task<Instituicao_TagsDTO> AddAsync(Instituicao_TagsDTO dto);
    Task<Instituicao_TagsDTO> InactivateAsync(Identifier id);
    Task<Instituicao_TagsDTO> DeleteAsync(Identifier id);
    Task<Instituicao_TagsDTO> UpdateAsync(Instituicao_TagsDTO dto);
}