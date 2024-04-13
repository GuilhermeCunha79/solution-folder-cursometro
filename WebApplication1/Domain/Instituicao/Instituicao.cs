using WebApplication1.Shared;
using WebApplication1.Domain.Tags;

namespace WebApplication1.Domain.Instituicao;

public class Instituicao : Entity<Identifier>, IAggregateRoot
{
    public EmailInstituicao Email { get; set; }
    public InstituicaoCodigo Codigo { get; set; }
    public InstituicaoFax Fax { get; set; }
    public InstituicaoLogo Logo { get; set; }
    public InstituicaoMorada Morada { get; set; }
    public InstituicaoTelefone Telefone { get; set; }
    public InstituicaoTipoEnsino TipoEnsino { get; set; }

    public Instituicao()
    {
    }

    public Instituicao(string email, string codigo, string fax, string logo, string morada, string telefone, string tipoEnsino)
    {
        Email = new EmailInstituicao(email);
        Codigo = new InstituicaoCodigo(codigo);
        Fax = new InstituicaoFax(fax);
        Logo = new InstituicaoLogo(logo);
        Morada = new InstituicaoMorada(morada);
        Telefone = new InstituicaoTelefone(telefone);
        TipoEnsino = new InstituicaoTipoEnsino(tipoEnsino);
    }
}