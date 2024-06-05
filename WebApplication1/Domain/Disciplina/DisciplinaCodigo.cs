﻿using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina;

public class DisciplinaCodigo:IValueObject
{
    public Identifier CodigoDisciplina { get; set; }

    public DisciplinaCodigo()
    {
        
    }

    public DisciplinaCodigo(int codigoDisciplina)
    {
        CodigoDisciplina = new Identifier(codigoDisciplina);
    }
}