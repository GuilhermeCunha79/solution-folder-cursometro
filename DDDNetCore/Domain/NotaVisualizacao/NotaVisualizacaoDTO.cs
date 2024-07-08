namespace WebApplication1.Domain.NotaVisualizacao;

public class NotaVisualizacaoDTO
{

    public string CodigoCurso;
    public string IdUtilizador;

    public string NotaPortuguesDecimo;
    public string NotaPortuguesDecimoPrim;
    public string NotaPortuguesDecimoSeg;
    public int CifPortugues;
    public string NotaExameInterno1Portugues;
    public string NotaExameInterno2Portugues;
    public string NotaExameExterno1Portugues;
    public string NotaExameExterno2Portugues;
    public bool IsIngressoPortugues;

    public string NotaEduFisicaDecimo;
    public string NotaEduFisicaDecimoPrim;
    public string NotaEduFisicaDecimoSeg;
    public string NotaExameExterno1EduFisica;
    public string NotaExameExterno2EduFisica;
    public int CifEduFisica;

    public string NotaFilosofiaDecimo;
    public string NotaFilosofiaDecimoPrim;
    public int CifFilosofia;
    public string NotaExameInterno1Filosofia;
    public string NotaExameInterno2Filosofia;
    public string NotaExameExterno1Filosofia;
    public string NotaExameExterno2Filosofia;
    public bool IsIngressoFilosofia;

    public string IdLingua;
    public string NotaLinguaDecimo;
    public string NotaLinguaDecimoPrim;
    public string NotaExameExterno1Lingua;
    public string NotaExameExterno2Lingua;
    public int CifLingua;
    public bool IsIngressoLingua;

    public string IdNotaTrienal;
    public string NotaTrienalDecimo;
    public string NotaTrienalDecimoPrim;
    public string NotaTrienalDecimoSeg;
    public int CifTrienal;
    public string NotaExameInterno1Trienal;
    public string NotaExameInterno2Trienal;
    public string NotaExameExterno1Trienal;
    public string NotaExameExterno2Trienal;
    public bool IsIngressoTrienal;
    public string CodigoExameTrienal;

    public string IdNotaBienal1;
    public string NotaBienal1Decimo;
    public string NotaBienal1DecimoPrim;
    public int CifBienal1;
    public string NotaExameInterno1Bienal1;
    public string NotaExameInterno2Bienal1;
    public string NotaExameExterno1Bienal1;
    public string NotaExameExterno2Bienal1;
    public bool IsIngressoBienal1;
    public string CodigoExameBienal1;

    public string IdNotaBienal2;
    public string NotaBienal2Decimo;
    public string NotaBienal2DecimoPrim;
    public int CifBienal2;
    public string NotaExameInterno1Bienal2;
    public string NotaExameInterno2Bienal2;
    public string NotaExameExterno1Bienal2;
    public string NotaExameExterno2Bienal2;
    public bool IsIngressoBienal2;
    public string CodigoExameBienal2;

    public string IdNotaAnual1;
    public string NotaAnual1DecimoSeg;
    public string NotaExameExterno1Anual1;
    public string NotaExameExterno2Anual1;
    public int CifAnual1;

    public string IdNotaAnual2;
    public string NotaAnual2DecimoSeg;
    public string NotaExameExterno1Anual2;
    public string NotaExameExterno2Anual2;
    public int CifAnual2;
    

    public NotaVisualizacaoDTO(int id, string notaPortuguesDecimo, string notaPortuguesDecimoPrim,
        string notaPortuguesDecimoSeg,
        string notaEduFisicaDecimo,
        string notaEduFisicaDecimoPrim, string notaEduFisicaDecimoSeg, string notaFilosofiaDecimo,
        string notaFilosofiaDecimoPrim, string idLingua, string notaLinguaDecimo, string notaLinguaDecimoPrim,
        string idNotaTrienal, string notaTrienalDecimo, string notaTrienalDecimoPrim, string notaTrienalDecimoSeg,
        string idNotaBienal1, string notaBienal1Decimo, string notaBienal1DecimoPrim, string idNotaBienal2,
        string notaBienal2Decimo,
        string notaBienal2DecimoPrim, string idNotaAnual1, string notaAnual1DecimoSeg, string idNotaAnual2,
        string notaAnual2DecimoSeg, string codigoCurso, string idUtilizador, int cifPortugues,
        string notaExameInterno1Portugues, string notaExameInterno2Portugues, string notaExameExterno1Portugues,
        string notaExameExterno2Portugues, bool isIngressoPortugues, int cifFilosofia,
        string notaExameInterno1Filosofia, string notaExameInterno2Filosofia, string notaExameExterno1Filosofia,
        string notaExameExterno2Filosofia, bool isIngressoFilosofia, int cifTrienal,
        string notaExameInterno1Trienal, string notaExameInterno2Trienal, string notaExameExterno1Trienal,
        string notaExameExterno2Trienal, bool isIngressoTrienal, int cifBienal1,
        string notaExameInterno1Bienal1, string notaExameInterno2Bienal1, string notaExameExterno1Bienal1,
        string notaExameExterno2Bienal1, bool isIngressoBienal1, int cifBienal2,
        string notaExameInterno1Bienal2, string notaExameInterno2Bienal2, string notaExameExterno1Bienal2,
        string notaExameExterno2Bienal2, bool isIngressoBienal2, int cifEduFisica, string notaExameExterno1EduFisica,
        string notaExameExterno2EduFisica, int cifLingua, string notaExameExterno1Lingua,
        string notaExameExterno2Lingua, bool isIngressoLingua, int cifAnual1, string notaExameExterno1Anual1,
        string notaExameExterno2Anual1, int cifAnual2, string notaExameExterno1Anual2,
        string notaExameExterno2Anual2)
    {
        CodigoCurso = codigoCurso;
        NotaPortuguesDecimo = notaPortuguesDecimo;
        NotaPortuguesDecimoPrim = notaPortuguesDecimoPrim;
        NotaPortuguesDecimoSeg = notaPortuguesDecimoSeg;
        NotaEduFisicaDecimo = notaEduFisicaDecimo;
        NotaEduFisicaDecimoPrim = notaEduFisicaDecimoPrim;
        NotaEduFisicaDecimoSeg = notaEduFisicaDecimoSeg;
        NotaFilosofiaDecimo = notaFilosofiaDecimo;
        NotaFilosofiaDecimoPrim = notaFilosofiaDecimoPrim;
        IdLingua = idLingua;
        NotaLinguaDecimo = notaLinguaDecimo;
        NotaLinguaDecimoPrim = notaLinguaDecimoPrim;
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

        IdUtilizador = idUtilizador;
        IsIngressoLingua = isIngressoLingua;
        CifPortugues = cifPortugues;
        NotaExameInterno1Portugues = notaExameInterno1Portugues;
        NotaExameInterno2Portugues = notaExameInterno2Portugues;
        NotaExameExterno1Portugues = notaExameExterno1Portugues;
        NotaExameExterno2Portugues = notaExameExterno2Portugues;
        IsIngressoPortugues = isIngressoPortugues;

        CifTrienal = cifTrienal;
        NotaExameInterno1Trienal = notaExameInterno1Trienal;
        NotaExameInterno2Trienal = notaExameInterno2Trienal;
        NotaExameExterno1Trienal = notaExameExterno1Trienal;
        NotaExameExterno2Trienal = notaExameExterno2Trienal;
        IsIngressoTrienal = isIngressoTrienal;
        CifBienal1 = cifBienal1;
        NotaExameInterno1Bienal1 = notaExameInterno1Bienal1;
        NotaExameInterno2Bienal1 = notaExameInterno2Bienal1;
        NotaExameExterno1Bienal1 = notaExameExterno1Bienal1;
        NotaExameExterno2Bienal1 = notaExameExterno2Bienal1;
        IsIngressoBienal1 = isIngressoBienal1;
        CifBienal2 = cifBienal2;
        NotaExameInterno1Bienal2 = notaExameInterno1Bienal2;
        NotaExameInterno2Bienal2 = notaExameInterno2Bienal2;
        NotaExameExterno1Bienal2 = notaExameExterno1Bienal2;
        NotaExameExterno2Bienal2 = notaExameExterno2Bienal2;
        IsIngressoBienal2 = isIngressoBienal2;
        CifFilosofia = cifFilosofia;
        NotaExameInterno1Filosofia = notaExameInterno1Filosofia;
        NotaExameInterno2Filosofia = notaExameInterno2Filosofia;
        NotaExameExterno1Filosofia = notaExameExterno1Filosofia;
        NotaExameExterno2Filosofia = notaExameExterno2Filosofia;
        IsIngressoFilosofia = isIngressoFilosofia;
        CifEduFisica = cifEduFisica;
        NotaExameExterno1EduFisica = notaExameExterno1EduFisica;
        NotaExameExterno2EduFisica = notaExameExterno2EduFisica;

        CifLingua = cifLingua;
        NotaExameExterno1Lingua = notaExameExterno1Lingua;
        NotaExameExterno2Lingua = notaExameExterno2Lingua;

        CifAnual1 = cifAnual1;
        NotaExameExterno1Anual1 = notaExameExterno1Anual1;
        NotaExameExterno2Anual1 = notaExameExterno2Anual1;

        CifAnual2 = cifAnual2;
        NotaExameExterno1Anual2 = notaExameExterno1Anual2;
        NotaExameExterno2Anual2 = notaExameExterno2Anual2;
    }
}