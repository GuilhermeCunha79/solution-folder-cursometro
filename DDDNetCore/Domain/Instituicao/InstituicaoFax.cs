using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoFax : IValueObject
{

    public string Fax { get; set; }

    public InstituicaoFax()
    {
        
    }

    public InstituicaoFax(string fax)
    {
        Fax = fax;
    }
}