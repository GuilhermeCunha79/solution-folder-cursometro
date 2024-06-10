using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.CursoSecundario;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.CursoSecundario;

public class CursoSecundarioRepository : BaseRepository<Domain.CursoSecundario.CursoSecundario, Identifier>,
    ICursoSecundarioRepository
{
    private readonly DDDSample1DbContext _context;

    public CursoSecundarioRepository(DDDSample1DbContext context) : base(context.CursoSecundarios)
    {
        _context = context;
    }


    public async Task<Domain.CursoSecundario.CursoSecundario> GetByCodCursoSec(int codCurso)
    {
        var query =
            @"SELECT [j].[CursoSecundarioCodigo],  [j].[CursoSecundarioNome]
                    FROM [Curso_Tags] AS [j]
                WHERE [j].[CursoSecundarioCodigo] = @codigoCurso";


        return await _context.CursoSecundarios.FromSqlRaw(query, new SqlParameter("codigoCurso", codCurso))
            .FirstOrDefaultAsync();
    }
}