using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public interface IInstituicaoService
{
    Task<List<InstituicaoDTO>> GetAllAsync();
    Task<InstituicaoDTO> GetByIdAsync(Identifier id);
    Task<InstituicaoDTO> GetByCodigo(Identifier id);
    Task<InstituicaoDTO> AddAsync(InstituicaoDTO dto);
    Task<InstituicaoDTO> InactivateAsync(Identifier id);
    Task<InstituicaoDTO> DeleteAsync(Identifier id);
    Task<InstituicaoDTO> UpdateAsync(InstituicaoDTO dto);
}