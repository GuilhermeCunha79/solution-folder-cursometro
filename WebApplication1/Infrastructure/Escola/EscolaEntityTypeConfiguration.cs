﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Escola;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Escola;

public class EscolaEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Escola.Escola>
{
    public void Configure(EntityTypeBuilder<Domain.Escola.Escola> builder)
    {
        builder.ToTable("Escola", SchemaNames.DDDSample1);
        builder.HasKey(b=>b.Id);

        builder.Property(b=>b.Id).HasConversion(v=>v.Value,
            v=>new Identifier(v));
        builder.Property(b=>b.EscolaNome).HasConversion(v=>v.NomeEscola,
            v=>new EscolaNome(v));
        builder.Property(b=>b.IdDistrito).HasConversion(v=>v.Value,
            v=>new Identifier(v));
        builder.Property(b=>b.IdRegiao).HasConversion(v=>v.Value,
            v=>new Identifier(v));
        
        builder
            .HasOne(e => e.Utilizador)
            .WithOne(j => j.Escola)
            .HasForeignKey<Domain.Utilizador.Utilizador>(e=>e.IdEscola);
    }
}