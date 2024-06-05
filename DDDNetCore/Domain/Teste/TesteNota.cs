﻿using WebApplication1.Shared;

namespace WebApplication1.Domain.Teste;

public class TesteNota:IValueObject
{
    public double NotaTeste { get; set; }

    public TesteNota()
    {
        
    }

    public TesteNota(double notaTeste)
    {
        NotaTeste = notaTeste;
    }
}