using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public interface ICandidaturaRepository:IRepository<Candidatura,Identifier>
{
    Task<Candidatura> GetByCodigoCurso(string codigo);
}