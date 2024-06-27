namespace WebApplication1.Domain.Utilizador;

public class UtilizadorDTO
{
    public string Id;
    public string Nome;
    public int Ano;
    public int Idade;
    public string Password;
    public int IdEscola;

    public UtilizadorDTO(string id, string nome, int ano, int idade, string password, int idEscola)
    {
        Id = id;
        Nome = nome;
        Ano = ano;
        Idade = idade;
        Password = password;
        IdEscola = idEscola;
    }
}