﻿namespace WebApplication1.Domain.NotaVisualizacao;

public class NotaVisualizacaoDTO
{
    public int Id;
    
    public string CodigoCurso;
    public string IdUtilizador;
    
    public string NotaPortuguesDecimo;
    public string NotaPortuguesDecimoPrim;
    public string NotaPortuguesDecimoSeg;
    
    public string NotaEduFisicaDecimo;
    public string NotaEduFisicaDecimoPrim;
    public string NotaEduFisicaDecimoSeg;
    public string NotaFilosofiaDecimo;
    public string NotaFilosofiaDecimoPrim;
    
    public string IdNotaTrienal;
    public string NotaTrienalDecimo;
    public string NotaTrienalDecimoPrim;
    public string NotaTrienalDecimoSeg;
    
    public string IdNotaBienal1;
    public string NotaBienal1Decimo;
    public string NotaBienal1DecimoPrim;
    
    public string IdNotaBienal2;
    public string NotaBienal2Decimo;
    public string NotaBienal2DecimoPrim;
    
    public string IdNotaAnual1;
    public string NotaAnual1DecimoSeg;
    
    public string IdNotaAnual2;
    public string NotaAnual2DecimoSeg;

    public int CifDisciplina;

    public string NotaExame;
    public bool IsIngresso;
    public string CodigoExame;

    public NotaVisualizacaoDTO(int id,string notaPortuguesDecimo, string notaPortuguesDecimoPrim,
        string notaPortuguesDecimoSeg,
        string notaEduFisicaDecimo,
        string notaEduFisicaDecimoPrim, string notaEduFisicaDecimoSeg, string notaFilosofiaDecimo,
        string notaFilosofiaDecimoPrim,
        string idNotaTrienal, string notaTrienalDecimo, string notaTrienalDecimoPrim, string notaTrienalDecimoSeg,
        string idNotaBienal1,
        string notaBienal1Decimo, string notaBienal1DecimoPrim, string idNotaBienal2, string notaBienal2Decimo,
        string notaBienal2DecimoPrim,
        string idNotaAnual1, string notaAnual1DecimoSeg, string idNotaAnual2, string notaAnual2DecimoSeg,
        int cifDisciplina,string notaExame, bool isIngresso,string codigoExame, string codigoCurso, string idUtilizador)
    {
        Id = id;
        CodigoCurso = codigoCurso;
        NotaPortuguesDecimo = notaPortuguesDecimo;
        NotaPortuguesDecimoPrim = notaPortuguesDecimoPrim;
        NotaPortuguesDecimoSeg = notaPortuguesDecimoSeg;
        NotaEduFisicaDecimo = notaEduFisicaDecimo;
        NotaEduFisicaDecimoPrim = notaEduFisicaDecimoPrim;
        NotaEduFisicaDecimoSeg = notaEduFisicaDecimoSeg;
        NotaFilosofiaDecimo = notaFilosofiaDecimo;
        NotaFilosofiaDecimoPrim = notaFilosofiaDecimoPrim;
        IdNotaTrienal = idNotaTrienal;
        NotaTrienalDecimo = notaTrienalDecimo;
        NotaTrienalDecimoPrim = notaTrienalDecimoPrim;
        NotaTrienalDecimoSeg = notaTrienalDecimoSeg;
        IdNotaBienal1 = idNotaBienal1;
        NotaBienal1Decimo = notaBienal1Decimo;
        NotaBienal1DecimoPrim = notaBienal1DecimoPrim;
        IdNotaBienal2 = idNotaBienal2;
        NotaBienal2Decimo = notaBienal2Decimo;
        NotaBienal2DecimoPrim = notaBienal2DecimoPrim;
        IdNotaAnual1 = idNotaAnual1;
        NotaAnual1DecimoSeg = notaAnual1DecimoSeg;
        IdNotaAnual2 = idNotaAnual2;
        NotaAnual2DecimoSeg = notaAnual2DecimoSeg;
        CifDisciplina = cifDisciplina;
        NotaExame = notaExame;
        IsIngresso = isIngresso;
        CodigoExame = codigoExame;
        IdUtilizador = idUtilizador;
    }
}