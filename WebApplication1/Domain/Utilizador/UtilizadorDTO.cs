namespace WebApplication1.Domain.Utilizador;

public class UtilizadorDTO
{
    public Guid Id;
    public string Nome;
    public int Ano;
    public int Idade;
    public string Password;

    public UtilizadorDTO(Guid id, string nome, int ano, int idade, string password)
    {
        Id = id;
        Nome = nome;
        Ano = ano;
        Idade = idade;
        Password = password;
    }
}