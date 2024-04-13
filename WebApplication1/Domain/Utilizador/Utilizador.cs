using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador;

public class Utilizador : Entity<Identifier>
{
    public UtilizadorEscola UtilizadorEscola { get; set; }
    public UtilizadorIdade UtilizadorIdade { get; set; }
    public UtilizadorNome UtilizadorNome { get; set; }
    public UtilizadorPassword UtilizadorPassword { get; set; }

    public Utilizador()
    {
        
    }

    public Utilizador(string escola, string idade, string nome, string password)
    {
        Id = new Identifier(Guid.NewGuid());
        UtilizadorEscola = new UtilizadorEscola(escola);
        UtilizadorIdade = new UtilizadorIdade(idade);
        UtilizadorNome = new UtilizadorNome(nome);
        UtilizadorPassword = new UtilizadorPassword(password);
    }
}