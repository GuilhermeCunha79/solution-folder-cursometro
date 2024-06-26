using WebApplication1.Shared;

namespace WebApplication1.Domain.Media;

public interface IMediaRepository:IRepository<Media,Identifier>
{
    Task<Media> GetByIdUtilizador(string idUtilizador);
}