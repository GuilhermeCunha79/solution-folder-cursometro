using WebApplication1.Infrastructure;
using WebApplication1.Shared;

namespace WebApplication1.Domain.CursoSecundario;

public class CursoSecundarioService:ICursoSecundarioService
{
    private readonly UnitOfWork _unitOfWork;
    private readonly ICursoSecundarioRepository _repo;

    public CursoSecundarioService(UnitOfWork unitOfWork, ICursoSecundarioRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }
    
    public async Task<CursoSecundarioDTO> GetByIdAsync(Identifier id)
    {
        var cursoSec = await _repo.GetByIdAsync(id);

        return new CursoSecundarioDTO(cursoSec.CursoSecundarioCodigo.IntValue,
            cursoSec.CursoSecundarioNome.NomeCursoSecundario);
    }

    public async Task<List<CursoSecundarioDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<CursoSecundarioDTO> listDto = list.ConvertAll(cursoSec => new CursoSecundarioDTO(
            cursoSec.CursoSecundarioCodigo.IntValue,
            cursoSec.CursoSecundarioNome.NomeCursoSecundario));

        return listDto;
    }

    public async Task<CursoSecundarioDTO> GetByCursoCodigoSec(Identifier codigo)
    {
        var dto = await _repo.GetByCodCursoSec(codigo);

        return new CursoSecundarioDTO(
            dto.CursoSecundarioCodigo.IntValue,
            dto.CursoSecundarioNome.NomeCursoSecundario);

    }

    public async Task<CursoSecundarioDTO> AddAsync(CursoSecundarioDTO dto)
    {
        var cursoSecundario = new CursoSecundario(dto.CodigoCursoSecundario,dto.NomeCursoSecundario);

        await _repo.AddAsync(cursoSecundario);
        await _unitOfWork.CommitAsync();

        return new CursoSecundarioDTO(
            cursoSecundario.CursoSecundarioCodigo.IntValue,
            cursoSecundario.CursoSecundarioNome.NomeCursoSecundario);
    }
}