﻿using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina;

public class DisciplinaNome:IValueObject
{
    public string NomeDisciplina { get; set; }

    public DisciplinaNome()
    {
        
    }

    public DisciplinaNome(string nomeDisciplina)
    {
        NomeDisciplina = nomeDisciplina;
    }
}