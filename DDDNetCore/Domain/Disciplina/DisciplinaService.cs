using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina;

public class DisciplinaService : IDisciplinaService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDisciplinaRepository _repo;

    public DisciplinaService(IUnitOfWork unitOfWork, IDisciplinaRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<DisciplinaDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<DisciplinaDTO> listDto = list.ConvertAll(disciplina =>
            new DisciplinaDTO(disciplina.Id.IntValue, disciplina.DisciplinaNome.NomeDisciplina,
                disciplina.DisciplinaTipo.TipoDisciplina));

        return listDto;
    }

    public async Task<DisciplinaDTO> GetByIdAsync(Identifier id)
    {
        var disciplina = await _repo.GetByIdAsync(id);

        return new DisciplinaDTO(disciplina.Id.IntValue, disciplina.DisciplinaNome.NomeDisciplina,
            disciplina.DisciplinaTipo.TipoDisciplina);
    }

    public async Task<DisciplinaDTO> GetByDisciplinaId(Identifier identifier)
    {
        var disciplina = await _repo.GetByDisciplinaId(identifier.StringValue);

        return new DisciplinaDTO(disciplina.Id.IntValue, disciplina.DisciplinaNome.NomeDisciplina,
            disciplina.DisciplinaTipo.TipoDisciplina);
    }

    public async Task<DisciplinaDTO> AddAsync(DisciplinaDTO dto)
    {
        var disciplina = new Disciplina(dto.DisciplinaNome, dto.DisciplinaTipo);

        await _repo.AddAsync(disciplina);

        await _unitOfWork.CommitAsync();

        return new DisciplinaDTO(disciplina.Id.IntValue, disciplina.DisciplinaNome.NomeDisciplina,
            disciplina.DisciplinaTipo.TipoDisciplina);
    }
}