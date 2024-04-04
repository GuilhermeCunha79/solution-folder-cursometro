﻿using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Calculo_ExameIngresso;

public class Calculo_ExameIngresso:Entity<Identifier>
{
    public ExameIngressoCodigo ExameIngressoCodigo;
    public Identifier CalculoIdentifier;

    public Calculo_ExameIngresso()
    {
        
    }

    public Calculo_ExameIngresso(string idCalculo, string exameCodigo)
    {
        Id = new Identifier(Guid.NewGuid());
        ExameIngressoCodigo = new ExameIngressoCodigo(exameCodigo);
        CalculoIdentifier = new Identifier(idCalculo);
    }

}