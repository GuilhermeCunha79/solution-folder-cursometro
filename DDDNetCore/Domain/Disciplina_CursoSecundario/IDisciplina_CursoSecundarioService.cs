using WebApplication1.Domain.NotaVisualizacao;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public interface IDisciplina_CursoSecundarioService
{
    Task<List<Disciplina_CursoSecundarioDTO>> GetAllAsync();
    Task<Disciplina_CursoSecundarioDTO> GetByIdAsync(Identifier id);
    Task<List<Disciplina_CursoSecundarioDTO>> GetByUtilizadorId(Identifier identifier);
    Task<List<Disciplina_CursoSecundarioDTO>> AddAsync(NotaVisualizacaoDTO dto);
    Task<Disciplina_CursoSecundarioDTO> InactivateAsync(Identifier id);
    Task<Disciplina_CursoSecundarioDTO> DeleteAsync(Identifier id);
    Task<Disciplina_CursoSecundarioDTO> UpdateAsync(Disciplina_CursoSecundarioDTO dto);
}