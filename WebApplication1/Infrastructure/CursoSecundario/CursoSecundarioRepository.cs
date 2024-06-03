using ConsoleApp1.Domain.CursoSecundario;
using ConsoleApp1.Infraestructure.Shared;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Curso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.CursoSecundario;

public class CursoSecundarioRepository: BaseRepository<ConsoleApp1.Domain.CursoSecundario.CursoSecundario,Identifier>,ICursoSecundarioRepository
{
    private readonly DDDSample1DbContext _context;
    
    public CursoSecundarioRepository(DDDSample1DbContext context) : base(context.CursoSecundarios)
    {
        _context = context;
    }
    

    public async Task<ConsoleApp1.Domain.CursoSecundario.CursoSecundario> GetByCodCursoSec(Identifier codCurso)
    {
        var query = 
            @"SELECT [j].[CursoSecundarioCodigo],  [j].[CursoSecundarioNome]
                    FROM [Curso_Tags] AS [j]
                WHERE [j].[CursoSecundarioCodigo] = @codigoCurso";


        return await _context.CursoSecundarios.FromSqlRaw(query, new SqlParameter("codigoCurso", codCurso)).FirstOrDefaultAsync();
    }
}