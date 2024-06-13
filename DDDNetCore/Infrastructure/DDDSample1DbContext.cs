using Microsoft.EntityFrameworkCore;
using WebApplication1.Infrastructure.Candidatura;
using WebApplication1.Infrastructure.Cif;
using WebApplication1.Infrastructure.Curso;
using WebApplication1.Infrastructure.Curso_Tags;
using WebApplication1.Infrastructure.CursoSecundario;
using WebApplication1.Infrastructure.Disciplina;
using WebApplication1.Infrastructure.Disciplina_CursoSecundario;
using WebApplication1.Infrastructure.Distrito;
using WebApplication1.Infrastructure.Escola;
using WebApplication1.Infrastructure.ExameIngresso;
using WebApplication1.Infrastructure.Favoritos;
using WebApplication1.Infrastructure.InformacoesCandidatura;
using WebApplication1.Infrastructure.Instituicao;
using WebApplication1.Infrastructure.Instituicao_Curso;
using WebApplication1.Infrastructure.Instituicao_Curso_ExameIngresso;
using WebApplication1.Infrastructure.Instituicao_Ranking;
using WebApplication1.Infrastructure.Instituicao_Tags;
using WebApplication1.Infrastructure.Medias;
using WebApplication1.Infrastructure.NotaVisualizacao;
using WebApplication1.Infrastructure.Ranking;
using WebApplication1.Infrastructure.Regiao;
using WebApplication1.Infrastructure.Tags;
using WebApplication1.Infrastructure.Teste;
using WebApplication1.Infrastructure.Utilizador;
using WebApplication1.Infrastructure.Utilizador_ExameIngresso;

namespace WebApplication1.Infrastructure;

public class DDDSample1DbContext : DbContext
{
    public DbSet<Domain.Instituicao.Instituicao> Instituicoes { get; set; }
    public DbSet<Domain.Curso.Curso> Cursos { get; set; }
    public DbSet<Domain.Disciplina.Disciplina> Disciplinas { get; set; }
    public DbSet<Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario> DisciplinaCursoSecundarios { get; set; }
    public DbSet<Domain.Candidatura.Candidatura> Candidaturas { get; set; }
    public DbSet<Domain.Cif.Cif> Cifs { get; set; }
    public DbSet<Domain.Curso_Tags.Curso_Tags> Curso_Tags { get; set; }
    public DbSet<Domain.CursoSecundario.CursoSecundario> CursoSecundarios { get; set; }
    public DbSet<Domain.Escola.Escola> Escolas { get; set; } 

    public int ObterNumeroDeJogadores()
    {
        return Instituicoes.Count()+1;
    }

    public DDDSample1DbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;Encrypt=true;TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

       
        modelBuilder.ApplyConfiguration(new FavoritosEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Utilizador_ExameIngressoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ExameIngressoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new MediaEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ExameIngressoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new InformacoesCandidaturaEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CandidaturaEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new InstituicaoCursoExameIngressoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new InstituicaoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CursoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CursoTagsEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new TagsEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Instituicao_TagsEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Instituicao_CursoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new DistritoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new RegiaoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new RankingEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Instituicao_RankingEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new EscolaEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new UtilizadorEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CursoSecundarioEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new DistritoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new DisciplinaEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Disciplina_CursoSecundarioEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new TesteEntityTypeConfiguration());
       // modelBuilder.ApplyConfiguration(new NotaVisualizacaoEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CifEntityTypeConfiguration());
    }
}