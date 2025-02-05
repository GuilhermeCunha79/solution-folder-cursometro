﻿using System.ComponentModel.DataAnnotations;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso;

public class Curso : Entity<Identifier>
{
    public CursoNome CursoNome { get; set; }
    public Instituicao_Curso.Instituicao_Curso InstituicaoCurso { get; set; }

    public ICollection<Curso_Tags.Curso_Tags> Curso_Tags { get; set; }
    public bool Active { get; set; }
    public Curso()
    {
        
    }

    public Curso(string codigoId, string nome)
    {
        Id = new Identifier(codigoId);
        CursoNome = new CursoNome(nome);
        Active = true;
    }

}