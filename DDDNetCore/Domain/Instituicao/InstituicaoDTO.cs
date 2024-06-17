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
    public byte[] Logo;
    public string MapaLink;
    public string PaginaLink;
    public int IdRanking;

    public InstituicaoDTO(string codigo, string nome, string morada, string telefone, string tipoEnsino, string fax,
        string email, byte[] logo, int idRanking, string mapaLink, string paginaLink)
    {
        Codigo = codigo;
        Nome = nome;
        Morada = morada;
        Telefone = telefone;
        TipoEnsino = tipoEnsino;
        Fax = fax;
        Email = email;
        Logo = logo;
        IdRanking = idRanking;
        MapaLink = mapaLink;
        PaginaLink = paginaLink;
    }
}