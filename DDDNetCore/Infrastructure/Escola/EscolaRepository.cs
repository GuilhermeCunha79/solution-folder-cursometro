using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Escola;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Escola;

public class EscolaRepository : BaseRepository<Domain.Escola.Escola, Identifier>, IEscolaRepository
{
    private readonly DDDSample1DbContext _context;

    public EscolaRepository(DDDSample1DbContext context) : base(context.Escolas)
    {
        _context = context;
    }

    public async Task<List<Domain.Escola.Escola>> GetByDistrito(string nome)
    {
        var query =
            @"SELECT * FROM [Escola] AS [j]
                  WHERE [j].[DistritoId] = (SELECT [e].[DistritoId] 
                          FROM [Distrito] AS [e]
                          WHERE [e].[DistritoNome] = @codigoCurso);";


        return await _context.Escolas.FromSqlRaw(query, new SqlParameter("codigoCurso", nome))
            .ToListAsync();
    }
}