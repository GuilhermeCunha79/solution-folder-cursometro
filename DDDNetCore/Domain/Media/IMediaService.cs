using WebApplication1.Shared;

namespace WebApplication1.Domain.Media;

public interface IMediaService
{
    Task<List<MediaDTO>> GetAllAsync();
    Task<MediaDTO> GetByIdAsync(Identifier id);
    Task<MediaDTO> GetByUtilizadorId(Identifier idUtilizador);
    Task<MediaDTO> AddAsync(MediaDTO dto);
    Task<MediaDTO> InactivateAsync(Identifier id);
    Task<MediaDTO> DeleteAsync(Identifier id);
    Task<MediaDTO> UpdateAsync(MediaDTO dto);
}