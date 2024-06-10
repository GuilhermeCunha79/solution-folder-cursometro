using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Disciplina;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Disciplina;

public class DisciplinaRepository : BaseRepository<Domain.Disciplina.Disciplina, Identifier>, IDisciplinaRepository
{
    private readonly DDDSample1DbContext _context;

    public DisciplinaRepository(DDDSample1DbContext context) : base(context.Disciplinas)
    {
        _context = context;
    }


    public async Task<Domain.Disciplina.Disciplina> GetByDisciplinaId(string identifier)
    {
        var query =
            @"SELECT *
                    FROM [Disciplina] AS [j]
                WHERE [j].[DisciplinaId] = @codigoCurso";


        return await _context.Disciplinas.FromSqlRaw(query, new SqlParameter("codigoCurso", identifier))
            .FirstOrDefaultAsync();
    }
}