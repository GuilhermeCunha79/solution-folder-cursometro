﻿using WebApplication1.Domain.Tags;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso;

public class Curso : Entity<Identifier>
{
    public CursoCodigo CursoCodigo;
    public CursoNome CursoNome;
    public bool Active { get; set; }

    public ICollection<Curso_Tags.Curso_Tags> Curso_Tags { get; set; }
    public Instituicao_Curso.Instituicao_Curso InstituicaoCurso { get; set; }

    public Curso()
    {
        
    }

    public Curso(string codigoId, string nome)
    {
        CursoCodigo = new CursoCodigo(codigoId);
        CursoNome = new CursoNome(nome);
        Active = true;
    }

}