using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Candidatura;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Candidatura;

public class CandidaturaRepository : BaseRepository<Domain.Candidatura.Candidatura, Identifier>, ICandidaturaRepository
{
    private readonly DDDSample1DbContext _context;

    public CandidaturaRepository(DDDSample1DbContext context) : base(context.Candidaturas)
    {
        _context = context;
    }

    public async Task<Domain.Candidatura.Candidatura> GetByCodigoCurso(string codigo)
    {
        var query =
            @"SELECT [j].[CandidaturaId],  [j].[CandidaturaAno], [j].[CandidaturaFase],[j].[Instituicao_CursoCodigo], [j].[IdInformacoes]
                FROM [Candidatura] AS [j]
                WHERE [j].[Instituicao_CursoCodigo] = @codigoCurso";


        return await _context.Candidaturas.FromSqlRaw(query, new SqlParameter("codigoCurso", codigo))
            .FirstOrDefaultAsync();
    }
}