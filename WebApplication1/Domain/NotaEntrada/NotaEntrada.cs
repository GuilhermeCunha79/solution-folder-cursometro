using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaEntrada;

public class NotaEntrada : Entity<Identifier>
{
    public NotaEntradaValor NotaEntradaValor { get; set; }


    public NotaEntrada()
    {
    }

    public NotaEntrada(string valor)
    {
        Id = new Identifier(Guid.NewGuid());
        NotaEntradaValor = new NotaEntradaValor(valor);
    }
}