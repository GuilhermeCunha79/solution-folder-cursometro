﻿using WebApplication1.Domain.Utilizador;
using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Teste;

public class Teste : Entity<Identifier>
{
    public TesteNota TesteNota { get; set; }
    public TesteAno TesteAno { get; set; }
    public TestePeriodo TestePeriodo { get; set; }
    public TesteDescricao TesteDescricao { get; set; }

    public Identifier UtilizadorId { get; set; }
    public Identifier DisciplinaId { get; set; }
    
    public Disciplina.Disciplina Disciplina { get; set; }
    public Utilizador Utilizador { get; set; }

    public Teste()
    {
        
    }

    public Teste(double testeNota, int testeAno, int testePeriodo, string testeDescricao)
    {
        TesteNota = new TesteNota(testeNota);
        TesteAno = new TesteAno(testeAno);
        TestePeriodo = new TestePeriodo(testePeriodo);
        TesteDescricao = new TesteDescricao(testeDescricao);
    }
}