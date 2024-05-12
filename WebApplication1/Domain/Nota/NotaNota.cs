using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Nota;

public class NotaNota:IValueObject
{
    public int Notaa { get; set; }

    public NotaNota()
    {
        
    }

    public NotaNota(int nota)
    {
        Notaa = nota;
    }
}