using ConsoleApp1.Infraestructure.Shared;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Candidatura;
using WebApplication1.Domain.Curso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Candidatura;

public class CandidaturaRepository:BaseRepository<Domain.Candidatura.Candidatura, Identifier>, ICandidaturaRepository
{
    private readonly DDDSample1DbContext _context;
    
    public CandidaturaRepository(DDDSample1DbContext context) : base(context.Candidaturas)
    {
        _context = context;
    }

    public Task<Domain.Candidatura.Candidatura> GetByCodigoCurso(string codigo)
    {
        throw new NotImplementedException();
    }
}