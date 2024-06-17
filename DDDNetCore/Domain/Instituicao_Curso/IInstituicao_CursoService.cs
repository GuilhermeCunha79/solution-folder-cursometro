using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public interface IInstituicao_CursoService
{
    Task<List<Instituicao_CursoDTO>> GetAllAsync();
    Task<Instituicao_CursoDTO> GetByIdAsync(Identifier id);
    Task<Instituicao_CursoDTO> AddAsync(Instituicao_CursoDTO dto);
    Task<Instituicao_CursoDTO> InactivateAsync(Identifier id);
    Task<Instituicao_CursoDTO> DeleteAsync(Identifier id);
    Task<Instituicao_CursoDTO> UpdateAsync(Instituicao_CursoDTO dto);
}