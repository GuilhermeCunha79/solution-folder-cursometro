using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador;

public class Utilizador : Entity<Identifier>
{
    public Identifier EscolaId { get; set; }
    public UtilizadorIdade UtilizadorIdade { get; set; }
    public UtilizadorNome UtilizadorNome { get; set; }
    public UtilizadorPassword UtilizadorPassword { get; set; }
    public UtilizadorAno UtilizadorAno { get; set; }

    public ICollection<Utilizador_ExameIngresso.Utilizador_ExameIngresso> UtilizadorExameIngresso { get; set; }
    public ICollection<Favoritos.Favoritos> Favoritos { get; set; }
    public ICollection<Teste.Teste> Testes { get; set; }
    public Escola.Escola Escola { get; set; }
    public Media.Media Media { get; set; }
    public ICollection<Disciplina_CursoSecundario.Disciplina_CursoSecundario> Disciplina_CursoSecundario { get; set; }
    

    public Utilizador()
    {
    }

    public Utilizador(int idEscola, int idade, string nome, string password, int ano)
    {
        Id = new Identifier(Guid.NewGuid());
        EscolaId = new Identifier(idEscola);
        UtilizadorIdade = new UtilizadorIdade(idade);
        UtilizadorNome = new UtilizadorNome(nome);
        UtilizadorPassword = new UtilizadorPassword(password);
        UtilizadorAno = new UtilizadorAno(ano);
    }
}