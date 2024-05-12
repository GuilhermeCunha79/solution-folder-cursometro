﻿using WebApplication1.Domain.Insituicao_Curso_ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.ExameIngresso;

public class ExameIngresso: Entity<Identifier>
{
    public ExameIngressoNome ExameIngressoNome;

    public ICollection<Utilizador_ExameIngresso.Utilizador_ExameIngresso> UtilizadorExameIngressos { get; set; }
    public ICollection<Instituicao_Curso_ExameIngresso> InstituicaoCursoExameIngressos { get; set; }

    public ExameIngresso()
    {
        
    }

    public ExameIngresso(string codigo, string nome)
    {
        Id = new ExameIngressoCodigo(codigo).GetCodigoExameIngresso();
        ExameIngressoNome = new ExameIngressoNome(nome);
    }
}