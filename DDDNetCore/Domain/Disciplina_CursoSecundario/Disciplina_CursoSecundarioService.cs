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
            new Disciplina_CursoSecundarioDTO(disciplina.Id.IntValue, disciplina.UtilizadorId.IntValue,
                disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg));

        return listDto;
    }

    public async Task<Disciplina_CursoSecundarioDTO> GetByIdAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.IntValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo, disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg);
    }

    public async Task<List<Disciplina_CursoSecundarioDTO>> GetByUtilizadorId(Identifier identifier)
    {
        var list = await _repo.GetByUtilizadorId(identifier.IntValue);

        List<Disciplina_CursoSecundarioDTO> listDto = list.ConvertAll(disciplina =>
            new Disciplina_CursoSecundarioDTO(disciplina.Id.IntValue, disciplina.UtilizadorId.IntValue,
                disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg));

        return listDto;
    }

    public async Task<List<Disciplina_CursoSecundarioDTO>> AddAsync(NotaVisualizacaoDTO dto)
    {
        var disciplinas = new List<Disciplina_CursoSecundario>
        {
            CreateDisciplina("POR", dto.CodigoCurso, dto.NotaPortuguesDecimo, dto.NotaPortuguesDecimoPrim,
                dto.NotaPortuguesDecimoSeg, dto.IdUtilizador),
            CreateDisciplina("EDU", dto.CodigoCurso, dto.NotaEduFisicaDecimo, dto.NotaEduFisicaDecimoPrim,
                dto.NotaEduFisicaDecimoSeg, dto.IdUtilizador),
            CreateDisciplina("FIL", dto.CodigoCurso, dto.NotaFilosofiaDecimo, dto.NotaFilosofiaDecimoPrim, "-",
                dto.IdUtilizador),
            CreateDisciplina(dto.IdNotaTrienal, dto.CodigoCurso, dto.NotaTrienalDecimo, dto.NotaTrienalDecimoPrim,
                dto.NotaTrienalDecimoSeg, dto.IdUtilizador),
            CreateDisciplina(dto.IdNotaBienal1, dto.CodigoCurso, dto.NotaBienal1Decimo, dto.NotaBienal1DecimoPrim, "-",
                dto.IdUtilizador),
            CreateDisciplina(dto.IdNotaBienal2, dto.CodigoCurso, dto.NotaBienal2Decimo, dto.NotaBienal2DecimoPrim, "-",
                dto.IdUtilizador),
            CreateDisciplina(dto.IdNotaAnual1, dto.CodigoCurso, "-", "-", dto.NotaAnual1DecimoSeg, dto.IdUtilizador),
            CreateDisciplina(dto.IdNotaAnual2, dto.CodigoCurso, "-", "-", dto.NotaAnual2DecimoSeg, dto.IdUtilizador)
        };

        foreach (var disciplina in disciplinas)
        {
            await _repo.AddAsync(disciplina);
        }

        await _unitOfWork.CommitAsync();

        List<Disciplina_CursoSecundarioDTO> listDto = disciplinas.ConvertAll(disciplina =>
            new Disciplina_CursoSecundarioDTO(disciplina.Id.IntValue, disciplina.UtilizadorId.IntValue,
                disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg));

        return listDto;
    }

    private Disciplina_CursoSecundario CreateDisciplina(string id, int codigoCurso, string notaDecimo,
        string notaDecimoPrim, string notaDecimoSeg, int idUtilizador)
    {
        return new Disciplina_CursoSecundario(id, codigoCurso, notaDecimo, notaDecimoPrim, notaDecimoSeg, idUtilizador);
    }

    public async Task<Disciplina_CursoSecundarioDTO> UpdateAsync(Disciplina_CursoSecundarioDTO dto)
    {
        var disciplina = await _repo.GetByIdAsync(new Identifier(dto.Idd));

        // change all fields
        disciplina.ChangeDisciplinaCursoNota(
            new Disciplina_CursoSecundarioNota(dto.NotaDecimo, dto.NotaDecimoPrim, dto.NotaDecimoSeg));

        await _unitOfWork.CommitAsync();

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.IntValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo, disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg);
    }


    public async Task<Disciplina_CursoSecundarioDTO> InactivateAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        if (disciplina == null)
            return null;

        disciplina.MarkAsInactive();

        await _unitOfWork.CommitAsync();

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.IntValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo, disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg);
    }

    public async Task<Disciplina_CursoSecundarioDTO> DeleteAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        if (disciplina == null)
            return null;

        _repo.Remove(disciplina);
        await _unitOfWork.CommitAsync();

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.IntValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.StringValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo, disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg);
    }
}