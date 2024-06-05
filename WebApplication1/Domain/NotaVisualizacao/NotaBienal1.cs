using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaVisualizacao;

public class NotaBienal1:IValueObject
{
    public Identifier IdNotaBienal1 { get; set; }
    public int NotaBienal1Decimo { get; set; }
    public int NotaBienal1DecimoPrim { get; set; }

    public NotaBienal1()
    {
        
    }

    public NotaBienal1(int idNotaBienal, int notaBienal1Decimo, int notaBienal1DecimoPrim)
    {
        IdNotaBienal1 = new Identifier(idNotaBienal);
        NotaBienal1Decimo = notaBienal1Decimo;
        NotaBienal1DecimoPrim = notaBienal1DecimoPrim;
    }
}