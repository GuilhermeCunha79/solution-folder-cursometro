using WebApplication1.Shared;

namespace WebApplication1.Domain.Cif;

public interface ICifRepository:IRepository<Cif,Identifier>
{
    Task<Cif> GetByUtilizadorDisciplina(int utilizadorId, string disciplinaId);
    Task<List<Cif>> GetByUtilizador(int utilizadorId);
}