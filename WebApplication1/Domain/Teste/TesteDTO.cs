namespace ConsoleApp1.Domain.Teste;

public class TesteDTO
{
    public double TesteNota;
    public int TesteAno;
    public int TestePeriodo;
    public string TesteDescricao;

    public TesteDTO(double testeNota,int testeAno, int testePeriodo, string testeDescricao)
    {
        TesteNota = testeNota;
        TesteAno = testeAno;
        TestePeriodo = testePeriodo;
        TesteDescricao = testeDescricao;
    }
}