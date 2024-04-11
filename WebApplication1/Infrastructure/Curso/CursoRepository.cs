using ConsoleApp1.Infraestructure.Shared;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Curso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Curso;

public class CursoRepository : BaseRepository<Domain.Curso.Curso, Identifier>, ICursoRepository
{
    
    private readonly DDDSample1DbContext _context;
    
    public CursoRepository(DDDSample1DbContext context) : base(context.Cursos)
    {
        _context = context;
    }

    public async Task<Domain.Curso.Curso> GetByCodigoCurso(string codigo)
    {//ALTERAR QUANDO CRIAR OS DADOS
        var query = 
            @"SELECT [j].[NomeAssociacao],  [j].[NomeCurto], [j].[Acronimo],[j].[Active], [j].[Id]
                FROM [Associacao] AS [j]
                WHERE [j].[NomeAssociacao] = @codigoCurso";


        return await _context.Cursos.FromSqlRaw(query, new SqlParameter("codigoCurso", codigo))
            .FirstOrDefaultAsync();
    }
}