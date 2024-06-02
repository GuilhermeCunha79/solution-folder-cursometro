using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Cif;

public interface ICifRepository:IRepository<WebApplication1.Domain.Cif.Cif,Identifier>
{
    Task<WebApplication1.Domain.Cif.Cif> GetByUtilizadorId(int utilizadorId);
}