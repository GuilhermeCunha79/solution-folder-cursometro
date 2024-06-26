using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Media;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Medias;

public class MediaRepository:BaseRepository<Media,Identifier>,IMediaRepository
{

    private readonly DDDSample1DbContext _context;
    
    public MediaRepository(DDDSample1DbContext context) : base(context.Medias)
    {
        _context = context;
    }

    public async Task<Media> GetByIdUtilizador(string idUtilizador)
    {
        var query =
            @"SELECT * FROM [Media] AS [j]
                  WHERE [j].[UtilizadorId] = @utilizadorId";


        return await _context.Medias.FromSqlRaw(query, new SqlParameter("utilizadorId", idUtilizador))
            .FirstOrDefaultAsync();
    }
}