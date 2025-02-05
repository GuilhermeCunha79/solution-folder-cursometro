﻿using WebApplication1.Shared;

namespace WebApplication1.Domain.Escola;

public class Escola:Entity<Identifier>
{
    public EscolaNome EscolaNome { get; set; }
    public Identifier DistritoId { get; set; }
    public Distrito.Distrito Distrito { get; set; }
    public Utilizador.Utilizador Utilizador { get; set; }
    public bool Active { get; set; }
    
    public Escola()
    {
        
    }

    public Escola(int idEscola, string nomeEscola, string idDistrito)
    {
        Id = new Identifier(idEscola);
        EscolaNome = new EscolaNome(nomeEscola);
        DistritoId = new Identifier(idDistrito);
        Active = true;
    }
    
    public void MarkAsInactive()
    {
        if (!Active)
            throw new BusinessRuleValidationException(
                "A Escola selecionada já se encontra inativa.");
        Active = false;
    }
}