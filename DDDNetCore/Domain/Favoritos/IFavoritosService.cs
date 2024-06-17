using WebApplication1.Shared;

namespace WebApplication1.Domain.Favoritos;

public interface IFavoritosService
{
    Task<List<FavoritosDTO>> GetAllAsync();
    Task<FavoritosDTO> GetByIdAsync(Identifier id);
    Task<List<FavoritosDTO>> GetByUtilizadorId(Identifier id);
    Task<FavoritosDTO> AddAsync(FavoritosDTO dto);
    Task<FavoritosDTO> DeleteAsync(Identifier id);
    Task<FavoritosDTO> UpdateAsync(FavoritosDTO dto);
}