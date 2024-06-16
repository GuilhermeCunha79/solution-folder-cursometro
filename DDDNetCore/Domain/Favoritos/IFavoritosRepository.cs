using WebApplication1.Shared;

namespace WebApplication1.Domain.Favoritos;

public interface IFavoritosRepository:IRepository<Favoritos,Identifier>
{
    Task<List<Favoritos>> GetByUtilizadorId(Identifier id);
}