using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class Instituicao : Entity<Identifier>, IAggregateRoot
{
    public EmailInstituicao Email { get; set; }
  //  public InstituicaoCodigo Codigo { get; set; }
    public InstituicaoFax Fax { get; set; }
    public InstituicaoLogo Logo { get; set; }
    public InstituicaoMorada Morada { get; set; }
    public InstituicaoTelefone Telefone { get; set; }
    public InstituicaoTipoEnsino TipoEnsino { get; set; }
    public InstituicaoNome Nome { get; set; }
    public InstituicaoMapaLink MapaLink { get; set; }
    public InstituicaoPaginaLink PaginaLink { get; set; }

    public ICollection<Instituicao_Ranking.Instituicao_Ranking> InstituicaoRankings { get; set; }
    public ICollection<Instituicao_Tags.Instituicao_Tags> InstituicaoTags { get; set; }
    public Instituicao_Curso.Instituicao_Curso InstituicaoCurso { get; set; }

    public Instituicao()
    {
    }

    public Instituicao(string nome,string email, int codigo, string fax, byte[] logo, string morada, string telefone,
        string tipoEnsino, string mapaLink, string paginaLink)
    {
        Id = new InstituicaoCodigo(codigo).Codigo;
        Nome = new InstituicaoNome(nome);
        Email = new EmailInstituicao(email);
        Fax = new InstituicaoFax(fax);
        Logo = new InstituicaoLogo(logo);
        Morada = new InstituicaoMorada(morada);
        Telefone = new InstituicaoTelefone(telefone);
        TipoEnsino = new InstituicaoTipoEnsino(tipoEnsino);
        MapaLink = new InstituicaoMapaLink(mapaLink);
        PaginaLink = new InstituicaoPaginaLink(paginaLink);
    }
}