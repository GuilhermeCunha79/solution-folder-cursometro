﻿using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina;

public class DisciplinaTipo:IValueObject
{
    public string TipoDisciplina { get; set; }

    public DisciplinaTipo()
    {
        
    }

    public DisciplinaTipo(string tipo)
    {
        TipoDisciplina = tipo;
    }
}