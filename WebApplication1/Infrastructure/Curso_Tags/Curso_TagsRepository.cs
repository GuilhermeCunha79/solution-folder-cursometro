using ConsoleApp1.Infraestructure.Shared;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Curso_Tags;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Curso_Tags;

public class Curso_TagsRepository:BaseRepository<Domain.Curso_Tags.Curso_Tags,Identifier>,ICurso_TagsRepository
{
    private readonly DDDSample1DbContext _context;
    
    public Curso_TagsRepository(DDDSample1DbContext context) : base(context.Curso_Tags)
    {
        _context = context;
    }

    public async Task<List<Domain.Curso_Tags.Curso_Tags>> GetByCursoCodigoTagId(string codigo, Identifier tagId)
    {
        var query = 
            @"SELECT [j].[TagId],  [j].[CursoCodigo]
                    FROM [Curso_Tags] AS [j]
                WHERE [j].[TagId] = @codigoCurso and [j].[CursoCodigo] = tagId";


        return await _context.Curso_Tags.FromSqlRaw(query, new SqlParameter("codigoCurso", codigo),
            new SqlParameter("tagId",tagId.IntValue)).ToListAsync();
    }
}