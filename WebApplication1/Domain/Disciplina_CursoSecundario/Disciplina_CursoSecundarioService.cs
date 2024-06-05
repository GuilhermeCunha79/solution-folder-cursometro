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
                disciplina.DisciplinaCodigo.IntValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg));

        return listDto;
    }

    public async Task<Disciplina_CursoSecundarioDTO> GetByIdAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.IntValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.IntValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo, disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg);
    }

    public async Task<List<Disciplina_CursoSecundarioDTO>> GetByUtilizadorId(Identifier identifier)
    {
        var list = await _repo.GetByUtilizadorId(identifier.IntValue);

        List<Disciplina_CursoSecundarioDTO> listDto = list.ConvertAll(disciplina =>
            new Disciplina_CursoSecundarioDTO(disciplina.Id.IntValue, disciplina.UtilizadorId.IntValue,
                disciplina.DisciplinaCodigo.IntValue, disciplina.CodigoCursoSecundario.IntValue,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimo,
                disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
                , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg));

        return listDto;
    }

    public async Task<Disciplina_CursoSecundarioDTO> AddAsync(Disciplina_CursoSecundarioDTO dto)
    {
        var disciplina = new Disciplina_CursoSecundario(dto.DisciplinaCodigo, dto.CodigoCursoSecundario, dto.NotaDecimo,
            dto.NotaDecimoPrim, dto.NotaDecimoSeg, dto.UtilizadorId);

        await _repo.AddAsync(disciplina);

        await _unitOfWork.CommitAsync();

        return new Disciplina_CursoSecundarioDTO(disciplina.Id.IntValue, disciplina.UtilizadorId.IntValue,
            disciplina.DisciplinaCodigo.IntValue, disciplina.CodigoCursoSecundario.IntValue,
            disciplina.DisciplinaCursoSecundarioNota.NotaDecimo, disciplina.DisciplinaCursoSecundarioNota.NotaDecimoPrim
            , disciplina.DisciplinaCursoSecundarioNota.NotaDecimoSeg);
    }
}