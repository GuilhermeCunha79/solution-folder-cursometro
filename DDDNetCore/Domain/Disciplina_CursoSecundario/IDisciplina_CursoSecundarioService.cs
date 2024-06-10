using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public interface IDisciplina_CursoSecundarioService
{
    Task<List<Disciplina_CursoSecundarioDTO>> GetAllAsync();
    Task<Disciplina_CursoSecundarioDTO> GetByIdAsync(Identifier id);
    Task<List<Disciplina_CursoSecundarioDTO>> GetByUtilizadorId(Identifier identifier);
    Task<Disciplina_CursoSecundarioDTO> AddAsync(Disciplina_CursoSecundarioDTO dto);
}