namespace WebApplication1.Domain.Instituicao;

public class InstituicaoDTO
{
    public string Codigo;
    public string Nome;
    public string Morada;
    public string Telefone;
    public string TipoEnsino;
    public string Fax;
    public string Email;
    public string Logo;
    public string MapaLink;
    public string PaginaLink;
    public Guid IdRankingIntenacional;
    public Guid IdRankingPortugues;

    public InstituicaoDTO(string codigo, string nome, string morada, string telefone, string tipoEnsino, string fax,
        string email, string logo, Guid idRankingInternacional, Guid idRankingPortugues, string mapaLink, string paginaLink)
    {
        Codigo = codigo;
        Nome = nome;
        Morada = morada;
        Telefone = telefone;
        TipoEnsino = tipoEnsino;
        Fax = fax;
        Email = email;
        Logo = logo;
        IdRankingIntenacional = idRankingInternacional;
        IdRankingPortugues = idRankingPortugues;
        MapaLink = mapaLink;
        PaginaLink = paginaLink;
    }
}