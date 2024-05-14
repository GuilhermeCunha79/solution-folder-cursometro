using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Cif;

public class CifEduFisica : IValueObject
{
    public int EduFisicaCif { get; set; }

    public CifEduFisica()
    {
        
    }

    public CifEduFisica(int eduFisicaCif)
    {
        EduFisicaCif = eduFisicaCif;
    }
}