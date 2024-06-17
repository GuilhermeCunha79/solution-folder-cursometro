using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Instituicao;

public class InstituicaoRepository:
    BaseRepository<Domain.Instituicao.Instituicao, Identifier>, IInstituicaoRepository
{
    private readonly DDDSample1DbContext _context;
    
    public InstituicaoRepository(DDDSample1DbContext context) : base(context.Instituicoes)
    {
        _context = context;
    }

    public async Task<Domain.Instituicao.Instituicao> GetByCodigo(string id)
    {
        var query =
            @"SELECT * FROM [Instituicao] AS [j]
                  WHERE [j].[InstituicaoCodigo] = @codigoCurso)";


        return await _context.Instituicoes.FromSqlRaw(query, new SqlParameter("codigoCurso", id))
            .FirstOrDefaultAsync();
    }
}