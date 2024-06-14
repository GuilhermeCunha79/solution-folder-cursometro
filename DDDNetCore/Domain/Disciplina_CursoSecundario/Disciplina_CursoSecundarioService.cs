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
            new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue,disciplina.UtilizadorId.IntValue,
                disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
                disciplina.DisciplinaCursoCifDisciplina.DisciplinaCif,
                disciplina.DisciplinaCursoNotaExame.NotaExameIngresso,
                disciplina.DisciplinaCursoIngressoBool.BoolIngresso));

        return listDto;
    }

    public async Task<Disciplina_CursoSecundarioDTO> GetByIdAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue,disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
            disciplina.DisciplinaCursoCifDisciplina.DisciplinaCif,
            disciplina.DisciplinaCursoNotaExame.NotaExameIngresso,
            disciplina.DisciplinaCursoIngressoBool.BoolIngresso);
    }

    public async Task<List<Disciplina_CursoSecundarioDTO>> GetByUtilizadorId(Identifier identifier)
    {
        var list = await _repo.GetByUtilizadorId(identifier.IntValue);

        List<Disciplina_CursoSecundarioDTO> listDto = list.ConvertAll(disciplina =>
            new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue,disciplina.UtilizadorId.IntValue,
                disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
                disciplina.DisciplinaCursoCifDisciplina.DisciplinaCif,
                disciplina.DisciplinaCursoNotaExame.NotaExameIngresso,
                disciplina.DisciplinaCursoIngressoBool.BoolIngresso));

        return listDto;
    }

    public async Task<Disciplina_CursoSecundarioDTO> GetByUtilizadorDisciplina(Identifier utilizadorId, Identifier disciplinaCod)
    {
        var disciplina = await _repo.GetByUtilizadorDisciplina(utilizadorId.IntValue,disciplinaCod.StringValue);

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue,disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
            disciplina.DisciplinaCursoCifDisciplina.DisciplinaCif,
            disciplina.DisciplinaCursoNotaExame.NotaExameIngresso,
            disciplina.DisciplinaCursoIngressoBool.BoolIngresso);
    }
    

    public async Task<List<Disciplina_CursoSecundarioDTO>> AddAsync(NotaVisualizacaoDTO dto)
    {
        var disciplinas = new List<Disciplina_CursoSecundario>
        {
            CreateDisciplina("POR", dto.CodigoCurso, dto.NotaPortuguesDecimo, dto.NotaPortuguesDecimoPrim,
                dto.NotaPortuguesDecimoSeg, dto.IdUtilizador, dto.CifDisciplina, dto.NotaExame, dto.IsIngresso),
            CreateDisciplina("EDU", dto.CodigoCurso, dto.NotaEduFisicaDecimo, dto.NotaEduFisicaDecimoPrim,
                dto.NotaEduFisicaDecimoSeg, dto.IdUtilizador, dto.CifDisciplina, dto.NotaExame, dto.IsIngresso),
            CreateDisciplina("FIL", dto.CodigoCurso, dto.NotaFilosofiaDecimo, dto.NotaFilosofiaDecimoPrim, "-",
                dto.IdUtilizador, dto.CifDisciplina, dto.NotaExame, dto.IsIngresso),
            CreateDisciplina(dto.IdNotaTrienal, dto.CodigoCurso, dto.NotaTrienalDecimo, dto.NotaTrienalDecimoPrim,
                dto.NotaTrienalDecimoSeg, dto.IdUtilizador, dto.CifDisciplina, dto.NotaExame, dto.IsIngresso),
            CreateDisciplina(dto.IdNotaBienal1, dto.CodigoCurso, dto.NotaBienal1Decimo, dto.NotaBienal1DecimoPrim, "-",
                dto.IdUtilizador, dto.CifDisciplina, dto.NotaExame, dto.IsIngresso),
            CreateDisciplina(dto.IdNotaBienal2, dto.CodigoCurso, dto.NotaBienal2Decimo, dto.NotaBienal2DecimoPrim, "-",
                dto.IdUtilizador, dto.CifDisciplina, dto.NotaExame, dto.IsIngresso),
            CreateDisciplina(dto.IdNotaAnual1, dto.CodigoCurso, "-", "-", dto.NotaAnual1DecimoSeg, dto.IdUtilizador,
                dto.CifDisciplina, dto.NotaExame, dto.IsIngresso),
            CreateDisciplina(dto.IdNotaAnual2, dto.CodigoCurso, "-", "-", dto.NotaAnual2DecimoSeg, dto.IdUtilizador,
                dto.CifDisciplina, dto.NotaExame, dto.IsIngresso)
        };

        foreach (var disciplina in disciplinas)
        {
            await _repo.AddAsync(disciplina);
        }

        await _unitOfWork.CommitAsync();

        List<Disciplina_CursoSecundarioDTO> listDto = disciplinas.ConvertAll(disciplina =>
            new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue,disciplina.UtilizadorId.IntValue,
                disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
                disciplina.DisciplinaCursoCifDisciplina.DisciplinaCif,
                disciplina.DisciplinaCursoNotaExame.NotaExameIngresso,
                disciplina.DisciplinaCursoIngressoBool.BoolIngresso));

        return listDto;
    }

    private Disciplina_CursoSecundario CreateDisciplina(string codigoDisciplina, int codigoCurso, string notaDecimo,
        string notaDecimoPrim, string notaDecimoSeg, int idUtilizador, int cifDisciplina, string notaExame,
        bool isIngresso)
    {
        return new Disciplina_CursoSecundario(codigoDisciplina, codigoCurso, notaDecimo, notaDecimoPrim, notaDecimoSeg,
            cifDisciplina, notaExame, isIngresso,
            idUtilizador);
    }

    public async Task<Disciplina_CursoSecundarioDTO> UpdateAsync(Disciplina_CursoSecundarioDTO dto)
    {
        var disciplina = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields
        disciplina.ChangeDisciplinaCursoNota(
            new Disciplina_CursoSecundarioNota(dto.NotaDecimo, dto.NotaDecimoPrim, dto.NotaDecimoSeg));

        await _unitOfWork.CommitAsync();

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue,disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
            disciplina.DisciplinaCursoCifDisciplina.DisciplinaCif,
            disciplina.DisciplinaCursoNotaExame.NotaExameIngresso,
            disciplina.DisciplinaCursoIngressoBool.BoolIngresso);
    }


    public async Task<Disciplina_CursoSecundarioDTO> InactivateAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        if (disciplina == null)
            return null;

        disciplina.MarkAsInactive();

        await _unitOfWork.CommitAsync();

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue,disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
            disciplina.DisciplinaCursoCifDisciplina.DisciplinaCif,
            disciplina.DisciplinaCursoNotaExame.NotaExameIngresso,
            disciplina.DisciplinaCursoIngressoBool.BoolIngresso);
    }

    public async Task<Disciplina_CursoSecundarioDTO> DeleteAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        if (disciplina == null)
            return null;

        _repo.Remove(disciplina);
        await _unitOfWork.CommitAsync();

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.StringValue,disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg,
            disciplina.DisciplinaCursoCifDisciplina.DisciplinaCif,
            disciplina.DisciplinaCursoNotaExame.NotaExameIngresso,
            disciplina.DisciplinaCursoIngressoBool.BoolIngresso);
    }
}