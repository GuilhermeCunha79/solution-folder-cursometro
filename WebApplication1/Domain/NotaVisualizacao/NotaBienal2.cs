using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Nota;

public class NotaBienal2:IValueObject
{
    public Identifier IdNotaBienal2 { get; set; }
    public int NotaBienal2Decimo { get; set; }
    public int NotaBienal2DecimoPrim { get; set; }

    public NotaBienal2()
    {
        
    }

    public NotaBienal2(int idNotaBienal2, int notaBienal2Decimo, int notaBienal2DecimoPrim)
    {
        IdNotaBienal2 = new Identifier(idNotaBienal2);
        NotaBienal2Decimo = notaBienal2Decimo;
        NotaBienal2DecimoPrim = notaBienal2DecimoPrim;
    }
}