﻿using WebApplication1.Shared;

namespace WebApplication1.Domain.Teste;

public class TesteAno:IValueObject
{
    public int AnoTeste { get; set; }

    public TesteAno()
    {
        
    }
    
    public TesteAno(int anoTeste)
    {
        AnoTeste = anoTeste;
    }
}