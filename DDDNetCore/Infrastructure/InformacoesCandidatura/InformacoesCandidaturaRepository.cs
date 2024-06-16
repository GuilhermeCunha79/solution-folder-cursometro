using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.InformacoesCandidatura;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.InformacoesCandidatura;

public class InformacoesCandidaturaRepository :
    BaseRepository<Domain.InformacoesCandidatura.InformacoesCandidatura, Identifier>, IInformacoesCandidaturaRepository
{
    private readonly DDDSample1DbContext _context;
    
    public InformacoesCandidaturaRepository(DDDSample1DbContext context) : base(context.InformacoesCandidaturas)
    {
        _context = context;
    }

    public async Task<Domain.InformacoesCandidatura.InformacoesCandidatura> GetByCandidaturaId(string id)
    {
        var query =
            @"SELECT * FROM [InformacoesCandidatura] AS [j]
                  WHERE [j].[UtilizadorId] = @codigoCurso)";


        return await _context.InformacoesCandidaturas.FromSqlRaw(query, new SqlParameter("codigoCurso", id))
            .FirstOrDefaultAsync();
    }
}