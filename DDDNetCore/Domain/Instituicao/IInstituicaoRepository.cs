using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public interface IInstituicaoRepository:IRepository<Instituicao,Identifier>
{
    Task<Instituicao> GetByCodigo(string id);
}