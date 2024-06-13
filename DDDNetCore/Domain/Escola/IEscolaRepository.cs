using WebApplication1.Shared;

namespace WebApplication1.Domain.Escola;

public interface IEscolaRepository:IRepository<Escola,Identifier>
{
    Task<List<Escola>> GetByDistrito(string nome);
}