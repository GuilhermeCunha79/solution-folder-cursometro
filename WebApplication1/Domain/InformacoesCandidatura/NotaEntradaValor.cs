using WebApplication1.Shared;

namespace WebApplication1.Domain.InformacoesCandidatura;

public class NotaEntradaValor : IValueObject
{

    public int ValorNotaEntrada { get; set; }

    public NotaEntradaValor()
    {
        
    }
    
    public NotaEntradaValor(int valor)
    {
        ValorNotaEntrada = valor;
    }
}