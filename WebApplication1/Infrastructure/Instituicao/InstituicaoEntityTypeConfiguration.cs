using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Domain.Instituicao_Curso;

namespace WebApplication1.Infrastructure.Instituicao;

public class InstituicaoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Instituicao.Instituicao>
{
    public void Configure(EntityTypeBuilder<Domain.Instituicao.Instituicao> builder)
    {
        builder.ToTable("Instituicao", SchemaNames.DDDSample1);
        builder.HasKey(b=>b.Codigo);

        builder.Property(b => b.Codigo).HasConversion(v => v.Codigo,
            v=>new InstituicaoCodigo(v.ToString()));
        builder.Property(b => b.Nome).HasConversion(v=>v.Nome,
            v=>new InstituicaoNome(v.ToString()));
        builder.Property(b => b.Morada).HasConversion(v=>v.Morada,
            v=> new InstituicaoMorada(v.ToString()));
        builder.Property(b => b.Telefone).HasConversion(v=>v.Telefone,
            v=>new InstituicaoTelefone(v.ToString()));
        builder.Property(b => b.TipoEnsino).HasConversion(v => v.TipoEnsino,
            v=> new InstituicaoTipoEnsino(v.ToString()));
        builder.Property(b => b.Fax).HasConversion(v => v.Fax,
            v=>new InstituicaoFax(v.ToString()));
        builder.Property(b => b.Email).HasConversion(v => v.Email,
            v=>new EmailInstituicao(v.ToString()));
        builder.Property(b => b.Logo).HasConversion(v => v.Logo,
            v=> new InstituicaoLogo(v));
        builder.Property(b=>b.MapaLink).HasConversion(v=>v.MapaLink,
            v=>new InstituicaoMapaLink(v));
        builder.Property(b => b.PaginaLink).HasConversion(v=>v.LinkInstituicao,
            v=>new InstituicaoPaginaLink(v));
        
        builder.HasMany(e => e.InstituicaoRankings)
            .WithOne(j => j.Instituicao)
            .HasForeignKey(e => e.InstituicaoCodigo)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.InstituicaoTags)
            .WithOne(j => j.Instituicao)
            .HasForeignKey(e => e.InstituicaoCodigo)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(f => f.InstituicaoCurso)
            .WithOne(j => j.Instituicao)
            .HasForeignKey<Domain.Instituicao_Curso.Instituicao_Curso>(f => f.InstituicaoCodigo);
    }
}