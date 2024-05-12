using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Nota;

public class Nota:Entity<Identifier>
{
    public NotaAno NotaAno { get; set; }
    public NotaNota NotaNota { get; set; }
    public NotaFila NotaFila { get; set; }

    public Nota()
    {
        
    }

    public Nota(int ano, int nota, int fila)
    {
        NotaAno = new NotaAno(ano);
        NotaNota = new NotaNota(nota);

    }
}