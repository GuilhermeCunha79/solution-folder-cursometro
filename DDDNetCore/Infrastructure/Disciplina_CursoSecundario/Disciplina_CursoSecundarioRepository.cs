using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Disciplina;
using WebApplication1.Domain.Disciplina_CursoSecundario;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Disciplina_CursoSecundario;

public class 
    Disciplina_CursoSecundarioRepository : BaseRepository<Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario,
        Identifier>,IDisciplina_CursoSecundarioRepository
{

    private readonly DDDSample1DbContext _context;

    public Disciplina_CursoSecundarioRepository(DDDSample1DbContext context) : base(context.DisciplinaCursoSecundarios)
    {
        _context = context;
    }

    public async Task<List<Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario>> GetByUtilizadorId(
        string utilizadorId)
    {
        var query =
            @"SELECT *
                    FROM [Disciplina_CursoSecundario] AS [j]
                WHERE [j].[UtilizadorId] = @utilizadorId";


        return await _context.DisciplinaCursoSecundarios.FromSqlRaw(query, new SqlParameter("utilizadorId", utilizadorId))
            .ToListAsync();
    }

    public async Task<Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario> GetByUtilizadorDisciplina(int utilizadorId, string disciplinaCod)
    {
        var query =
            @"SELECT *
                    FROM [Disciplina_CursoSecundario] AS [j]
                WHERE [j].[UtilizadorId] = @utilizadorId AND [j].[Disciplina_CursoCodigo] = @disciplinaCod";


        return await _context.DisciplinaCursoSecundarios.FromSqlRaw(query, new SqlParameter("utilizadorId", utilizadorId),
                new SqlParameter("disciplinaCod",disciplinaCod))
            .FirstOrDefaultAsync();
    }
}