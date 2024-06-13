using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina;

public interface IDisciplinaService
{
    Task<List<DisciplinaDTO>> GetAllAsync();
    Task<DisciplinaDTO> GetByIdAsync(Identifier id);
    Task<DisciplinaDTO> GetByDisciplinaId(Identifier identifier);
    Task<DisciplinaDTO> AddAsync(DisciplinaDTO dto);
    Task<DisciplinaDTO> InactivateAsync(Identifier id);
    Task<DisciplinaDTO> DeleteAsync(Identifier id);
    Task<DisciplinaDTO> UpdateAsync(DisciplinaDTO dto);
}