using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Favoritos;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Favoritos;

public class FavoritosRepository:BaseRepository<Domain.Favoritos.Favoritos,Identifier>,IFavoritosRepository
{
    private readonly DDDSample1DbContext _context;
    
    public FavoritosRepository(DDDSample1DbContext context) : base(context.Favoritos)
    {
    }

    public async Task<List<Domain.Favoritos.Favoritos>> GetByUtilizadorId(Identifier id)
    {
        var query =
            @"SELECT * FROM [Favoritos] AS [j]
                  WHERE [j].[UtilizadorId] = @codigoCurso)";


        return await _context.Favoritos.FromSqlRaw(query, new SqlParameter("codigoCurso", id.IntValue))
            .ToListAsync();
    }
}