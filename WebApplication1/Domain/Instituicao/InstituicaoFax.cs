using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoFax : IValueObject
{

    private string Fax;

    public InstituicaoFax()
    {
        
    }

    public InstituicaoFax(string fax)
    {
        Fax = fax;
    }
}