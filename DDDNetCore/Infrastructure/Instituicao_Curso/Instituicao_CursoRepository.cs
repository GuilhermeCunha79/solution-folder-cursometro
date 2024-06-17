using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Instituicao_Curso;

public class Instituicao_CursoRepository : BaseRepository<Domain.Instituicao_Curso.Instituicao_Curso, Identifier>,
    IInstituicao_CursoRepository
{
    private readonly DDDSample1DbContext _context;
    
    public Instituicao_CursoRepository(DDDSample1DbContext context) : base(context.InstituicaoCursos)
    {
        _context = context;
    }
}