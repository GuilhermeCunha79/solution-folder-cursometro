using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso_Tags;

public interface ICurso_TagsService
{
    Task<Curso_TagsDTO> GetByIdAsync(Identifier id);
    Task<List<Curso_TagsDTO>> GetAllAsync();
    Task<List<Curso_TagsDTO>> GetByCursoCodigoTagId(string codigo, Identifier tagId);
    Task<Curso_TagsDTO> AddAsync(Curso_TagsDTO dto);
}