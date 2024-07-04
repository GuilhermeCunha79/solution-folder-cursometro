using WebApplication1.Domain.NotaVisualizacao;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundarioService : IDisciplina_CursoSecundarioService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDisciplina_CursoSecundarioRepository _repo;

    public Disciplina_CursoSecundarioService(IUnitOfWork unitOfWork, IDisciplina_CursoSecundarioRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<Disciplina_CursoSecundarioDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<Disciplina_CursoSecundarioDTO> listDto = list.ConvertAll(disciplina =>
            new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue, disciplina.UtilizadorId.IntValue,
                disciplina.DisciplinaId.StringValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
                disciplina.DisciplinaCursoCifDiscDisciplina.DisciplinaCif,
                disciplina.DisciplinaCursoNotaExameInterno1.NotaExameInterno1,
                disciplina.DisciplinaCursoNotaExameInterno2.NotaExameInterno2,
                disciplina.DisciplinaCursoNotaExameExterno1.NotaExameExterno1,
                disciplina.DisciplinaCursoNotaExameExterno2.NotaExameExterno2,
                disciplina.DisciplinaCursoIngresso.BoolIngresso));

        return listDto;
    }

    public async Task<Disciplina_CursoSecundarioDTO> GetByIdAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaId.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
            disciplina.DisciplinaCursoCifDiscDisciplina.DisciplinaCif,
            disciplina.DisciplinaCursoNotaExameInterno1.NotaExameInterno1,
            disciplina.DisciplinaCursoNotaExameInterno2.NotaExameInterno2,
            disciplina.DisciplinaCursoNotaExameExterno1.NotaExameExterno1,
            disciplina.DisciplinaCursoNotaExameExterno2.NotaExameExterno2,
            disciplina.DisciplinaCursoIngresso.BoolIngresso);
    }

    public async Task<List<Disciplina_CursoSecundarioDTO>> GetByUtilizadorId(string identifier)
    {
        var list = await _repo.GetByUtilizadorId(identifier);

        List<Disciplina_CursoSecundarioDTO> listDto = list.ConvertAll(disciplina =>
            new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue, disciplina.UtilizadorId.IntValue,
                disciplina.DisciplinaId.StringValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
                disciplina.DisciplinaCursoCifDiscDisciplina.DisciplinaCif,
                disciplina.DisciplinaCursoNotaExameInterno1.NotaExameInterno1,
                disciplina.DisciplinaCursoNotaExameInterno2.NotaExameInterno2,
                disciplina.DisciplinaCursoNotaExameExterno1.NotaExameExterno1,
                disciplina.DisciplinaCursoNotaExameExterno2.NotaExameExterno2,
                disciplina.DisciplinaCursoIngresso.BoolIngresso));

        return listDto;
    }

    public async Task<Disciplina_CursoSecundarioDTO> GetByUtilizadorDisciplina(Identifier utilizadorId,
        Identifier disciplinaCod)
    {
        var disciplina = await _repo.GetByUtilizadorDisciplina(utilizadorId.IntValue, disciplinaCod.StringValue);

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaId.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
            disciplina.DisciplinaCursoCifDiscDisciplina.DisciplinaCif,
            disciplina.DisciplinaCursoNotaExameInterno1.NotaExameInterno1,
            disciplina.DisciplinaCursoNotaExameInterno2.NotaExameInterno2,
            disciplina.DisciplinaCursoNotaExameExterno1.NotaExameExterno1,
            disciplina.DisciplinaCursoNotaExameExterno2.NotaExameExterno2,
            disciplina.DisciplinaCursoIngresso.BoolIngresso);
    }


    public async Task<List<Disciplina_CursoSecundarioDTO>> AddAsync(NotaVisualizacaoDTO dto)
    {
        var disciplinas = new List<Disciplina_CursoSecundario>
        {
            CreateDisciplina("POR", dto.CodigoCurso, dto.NotaPortuguesDecimo, dto.NotaPortuguesDecimoPrim,
                dto.NotaPortuguesDecimoSeg, dto.IdUtilizador, dto.CifPortugues, dto.NotaExameInterno1Portugues,
                dto.NotaExameInterno2Portugues, dto.NotaExameExterno1Portugues, dto.NotaExameExterno2Portugues,
                dto.IsIngressoPortugues,
                "639"),
            CreateDisciplina("EDU", dto.CodigoCurso, dto.NotaEduFisicaDecimo, dto.NotaEduFisicaDecimoPrim,
                dto.NotaEduFisicaDecimoSeg, dto.IdUtilizador, dto.CifEduFisica, "-",
                "-", dto.NotaExameExterno1EduFisica, dto.NotaExameExterno2EduFisica, false,
                "-"),
            CreateDisciplina("FIL", dto.CodigoCurso, dto.NotaFilosofiaDecimo, dto.NotaFilosofiaDecimoPrim, "-",
                dto.IdUtilizador, dto.CifFilosofia, dto.NotaExameInterno1Filosofia,
                dto.NotaExameInterno2Filosofia, dto.NotaExameExterno1Filosofia, dto.NotaExameExterno2Filosofia,
                dto.IsIngressoFilosofia, "714"),
            CreateDisciplina(dto.IdLingua, dto.CodigoCurso, dto.NotaLinguaDecimo, dto.NotaLinguaDecimoPrim, "-",
                dto.IdUtilizador, dto.CifLingua, "-",
                "-", dto.NotaExameExterno1Lingua, dto.NotaExameExterno2Lingua, dto.IsIngressoLingua, "550"),
            CreateDisciplina(dto.IdNotaTrienal, dto.CodigoCurso, dto.NotaTrienalDecimo, dto.NotaTrienalDecimoPrim,
                dto.NotaTrienalDecimoSeg, dto.IdUtilizador, dto.CifTrienal, dto.NotaExameInterno1Trienal,
                dto.NotaExameInterno2Trienal, dto.NotaExameExterno1Trienal, dto.NotaExameExterno2Trienal,
                dto.IsIngressoTrienal,
                dto.CodigoExameTrienal),
            CreateDisciplina(dto.IdNotaBienal1, dto.CodigoCurso, dto.NotaBienal1Decimo, dto.NotaBienal1DecimoPrim, "-",
                dto.IdUtilizador, dto.CifBienal1, dto.NotaExameInterno1Bienal1,
                dto.NotaExameInterno2Bienal1, dto.NotaExameExterno1Bienal1, dto.NotaExameExterno2Bienal1,
                dto.IsIngressoBienal1, dto.CodigoExameBienal1),
            CreateDisciplina(dto.IdNotaBienal2, dto.CodigoCurso, dto.NotaBienal2Decimo, dto.NotaBienal2DecimoPrim, "-",
                dto.IdUtilizador, dto.CifBienal2, dto.NotaExameInterno1Bienal1,
                dto.NotaExameInterno2Bienal2, dto.NotaExameExterno1Bienal1, dto.NotaExameExterno2Bienal1,
                dto.IsIngressoBienal1, dto.CodigoExameBienal2),
            CreateDisciplina(dto.IdNotaAnual1, dto.CodigoCurso, "-", "-", dto.NotaAnual1DecimoSeg, dto.IdUtilizador,
                dto.CifAnual1, "-",
                "-", dto.NotaExameExterno1Anual1, dto.NotaExameExterno1Anual1, false, "-"),
            CreateDisciplina(dto.IdNotaAnual2, dto.CodigoCurso, "-", "-", dto.NotaAnual2DecimoSeg, dto.IdUtilizador,
                dto.CifAnual2, "-",
                "-", dto.NotaExameExterno1Anual2, dto.NotaExameExterno2Anual2, false, "-")
        };

        foreach (var disciplina in disciplinas)
        {
            await _repo.AddAsync(disciplina);
        }

        await _unitOfWork.CommitAsync();

        List<Disciplina_CursoSecundarioDTO> listDto = disciplinas.ConvertAll(disciplina =>
            new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue, disciplina.UtilizadorId.IntValue,
                disciplina.DisciplinaId.StringValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
                disciplina.DisciplinaCursoCifDiscDisciplina.DisciplinaCif,
                disciplina.DisciplinaCursoNotaExameInterno1.NotaExameInterno1,
                disciplina.DisciplinaCursoNotaExameInterno2.NotaExameInterno2,
                disciplina.DisciplinaCursoNotaExameExterno1.NotaExameExterno1,
                disciplina.DisciplinaCursoNotaExameExterno2.NotaExameExterno2,
                disciplina.DisciplinaCursoIngresso.BoolIngresso));

        return listDto;
    }

    private Disciplina_CursoSecundario CreateDisciplina(string codigoDisciplina, string codigoCurso, string notaDecimo,
        string notaDecimoPrim, string notaDecimoSeg, string idUtilizador, int cifDisciplina, string notaExameInterno1,
        string notaExameInterno2, string notaExameExterno1, string notaExameExterno2,
        bool isIngresso, string codigoExame)
    {
        return new Disciplina_CursoSecundario(codigoDisciplina, codigoCurso, notaDecimo, notaDecimoPrim, notaDecimoSeg,
            cifDisciplina, notaExameInterno1, notaExameInterno2, notaExameExterno1, notaExameExterno2, isIngresso,
            idUtilizador, codigoExame);
    }

    public async Task<Disciplina_CursoSecundarioDTO> UpdateAsync(Disciplina_CursoSecundarioDTO dto)
    {
        var disciplina = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields
        disciplina.ChangeDisciplinaCursoNota(
            new Disciplina_CursoSecundarioNota(dto.NotaDecimo, dto.NotaDecimoPrim, dto.NotaDecimoSeg));

        await _unitOfWork.CommitAsync();

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaId.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
            disciplina.DisciplinaCursoCifDiscDisciplina.DisciplinaCif,
            disciplina.DisciplinaCursoNotaExameInterno1.NotaExameInterno1,
            disciplina.DisciplinaCursoNotaExameInterno2.NotaExameInterno2,
            disciplina.DisciplinaCursoNotaExameExterno1.NotaExameExterno1,
            disciplina.DisciplinaCursoNotaExameExterno2.NotaExameExterno2,
            disciplina.DisciplinaCursoIngresso.BoolIngresso);
    }


    public async Task<Disciplina_CursoSecundarioDTO> InactivateAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        if (disciplina == null)
            return null;

        disciplina.MarkAsInactive();

        await _unitOfWork.CommitAsync();

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaId.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
            disciplina.DisciplinaCursoCifDiscDisciplina.DisciplinaCif,
            disciplina.DisciplinaCursoNotaExameInterno1.NotaExameInterno1,
            disciplina.DisciplinaCursoNotaExameInterno2.NotaExameInterno2,
            disciplina.DisciplinaCursoNotaExameExterno1.NotaExameExterno1,
            disciplina.DisciplinaCursoNotaExameExterno2.NotaExameExterno2,
            disciplina.DisciplinaCursoIngresso.BoolIngresso);
    }

    public async Task<Disciplina_CursoSecundarioDTO> DeleteAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        if (disciplina == null)
            return null;

        _repo.Remove(disciplina);
        await _unitOfWork.CommitAsync();

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaId.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
            disciplina.DisciplinaCursoCifDiscDisciplina.DisciplinaCif,
            disciplina.DisciplinaCursoNotaExameInterno1.NotaExameInterno1,
            disciplina.DisciplinaCursoNotaExameInterno2.NotaExameInterno2,
            disciplina.DisciplinaCursoNotaExameExterno1.NotaExameExterno1,
            disciplina.DisciplinaCursoNotaExameExterno2.NotaExameExterno2,
            disciplina.DisciplinaCursoIngresso.BoolIngresso);
    }
}