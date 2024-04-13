using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso;

public class CursoService : ICursoService
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly ICursoRepository _repo;

    public CursoService(IUnitOfWork unitOfWork, ICursoRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<CursoDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<CursoDTO> listDto =
            list.ConvertAll(curso => new CursoDTO(curso.CursoCodigo.Codigo, curso.CursoNome.Nome));

        return listDto;
    }

    public async Task<CursoDTO> GetByCursoCodigo(string codigo)
    {
        var curso = await this._repo.GetByCodigoCurso(codigo);

        return new CursoDTO(curso.CursoCodigo.Codigo, curso.CursoNome.Nome);
    }
    
    public async Task<CursoDTO> GetByIdAsync(Identifier id)
    {
        var curso = await _repo.GetByIdAsync(id);
        
        return new CursoDTO(curso.CursoCodigo.Codigo, curso.CursoNome.Nome);
    }

    public async Task<CursoDTO> AddAsync(CursoDTO dto)
    {
        var curso = new Curso(dto.CodigoCurso, dto.NomeCurso);

        await _repo.AddAsync(curso);

        await _unitOfWork.CommitAsync();

        return new CursoDTO(curso.CursoCodigo.Codigo, curso.CursoNome.Nome);
    }
    
    
    

}