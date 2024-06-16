using WebApplication1.Shared;

namespace WebApplication1.Domain.InformacoesCandidatura;

public interface IInformacoesCandidaturaRepository:IRepository<InformacoesCandidatura,Identifier>
{
    Task<InformacoesCandidatura> GetByCandidaturaId(string id);
}