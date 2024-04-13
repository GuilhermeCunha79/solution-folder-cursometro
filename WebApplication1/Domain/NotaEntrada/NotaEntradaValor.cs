using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaEntrada;

public class NotaEntradaValor : IValueObject
{

    public string ValorNotaEntrada { get; set; }

    public NotaEntradaValor()
    {
        
    }
    
    public NotaEntradaValor(string valor)
    {
        ValorNotaEntrada = valor;
    }
}