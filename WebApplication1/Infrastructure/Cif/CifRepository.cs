﻿using ConsoleApp1.Domain.Cif;
using ConsoleApp1.Infraestructure.Shared;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Cif;

public class CifRepository:BaseRepository<Domain.Cif.Cif,Identifier>, ICifRepository
{
    private readonly DDDSample1DbContext _context;
    
    public CifRepository(DDDSample1DbContext context) : base(context.Cifs)
    {
        _context = context;
    }


    public async Task<Domain.Cif.Cif> GetByUtilizadorId(int utilizadorId)
    {
        var query = 
            @"SELECT [j].*
                FROM [Cif] AS [j]
                WHERE [j].[UtilizadorId] = @utilizadorId";


        return await _context.Cifs.FromSqlRaw(query, new SqlParameter("utilizadorId", utilizadorId))
            .FirstOrDefaultAsync();
    }
}