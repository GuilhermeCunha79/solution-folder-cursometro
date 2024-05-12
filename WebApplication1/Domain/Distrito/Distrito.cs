using WebApplication1.Shared;

namespace WebApplication1.Domain.Distrito;

public class Distrito:Entity<Identifier>
{
    public DistritoNome DistritoNome { get; set; }
    public Escola.Escola Escola { get; set; }
    public Identifier RegiaoId { get; set; }
    public Regiao.Regiao Regiao { get; set; }

    public Distrito()
    {
        
    }

    public Distrito(string distritoCod,string nome)
    {
        Id = new DistritoCodigo(distritoCod).CodigoDistrito;
        DistritoNome = new DistritoNome(nome);
    }
}