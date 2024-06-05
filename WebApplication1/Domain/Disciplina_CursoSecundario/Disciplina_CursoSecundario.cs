﻿using WebApplication1.Domain.CursoSecundario;
using WebApplication1.Domain.Disciplina;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundario : Entity<Identifier>
{
    public Identifier DisciplinaCodigo { get; set; }
    public Identifier CodigoCursoSecundario { get; set; }
    public Disciplina_CursoSecundarioNota DisciplinaCursoSecundarioNota { get; set; }
    public CursoSecundario.CursoSecundario CursoSecundario { get; set; }
    public Disciplina.Disciplina Disciplina { get; set; }
    public Identifier UtilizadorId { get; set; }
    public Utilizador.Utilizador Utilizador { get; set; }

    public Disciplina_CursoSecundario()
    {
    }

    public Disciplina_CursoSecundario(int codigoDisciplina, int codigoCursoSecundario, string disciplinaDecimo,
        string disciplinaDecimoPrim, string disciplinaDecimoSeg,int utilizadorId)
    {
        DisciplinaCodigo = new DisciplinaCodigo(codigoDisciplina).CodigoDisciplina;
        CodigoCursoSecundario = new CursoSecundarioCodigo(codigoCursoSecundario).CodigoCursoSecundario;
        DisciplinaCursoSecundarioNota =
            new Disciplina_CursoSecundarioNota(disciplinaDecimo, disciplinaDecimoPrim, disciplinaDecimoSeg);
        UtilizadorId = new Identifier(utilizadorId);
    }
}