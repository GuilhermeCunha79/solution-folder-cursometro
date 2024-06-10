using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Favoritos;

public class Favoritos:Entity<Identifier>
{
    public Identifier InstituicaoCursoCodigo { get; set; }
    public Identifier UtilizadorId { get; set; }
    
    public Instituicao_Curso.Instituicao_Curso InstituicaoCurso { get; set; }

    public Utilizador.Utilizador Utilizador { get; set; }

    public Favoritos()
    {
        
    }

    public Favoritos(string utilGuid, string codigo)
    {
        UtilizadorId = new Identifier(utilGuid);
        InstituicaoCursoCodigo = new Instituicao_CursoCodigo(codigo).Codigo;
    }
    
}