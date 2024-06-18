using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso_ExameIngresso;

public interface IInstituicao_Curso_ExameIngressoService
{
    Task<List<Instituicao_Curso_ExameIngressoDTO>> GetAllAsync();
    Task<Instituicao_Curso_ExameIngressoDTO> GetByIdAsync(Identifier id);
    Task<Instituicao_Curso_ExameIngressoDTO> AddAsync(Instituicao_Curso_ExameIngressoDTO dto);
    Task<Instituicao_Curso_ExameIngressoDTO> InactivateAsync(Identifier id);
    Task<Instituicao_Curso_ExameIngressoDTO> DeleteAsync(Identifier id);
    Task<Instituicao_Curso_ExameIngressoDTO> UpdateAsync(Instituicao_Curso_ExameIngressoDTO dto);
}