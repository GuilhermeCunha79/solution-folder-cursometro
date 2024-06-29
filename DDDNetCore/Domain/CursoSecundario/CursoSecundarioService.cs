using WebApplication1.Infrastructure;
using WebApplication1.Shared;

namespace WebApplication1.Domain.CursoSecundario;

public class CursoSecundarioService : ICursoSecundarioService
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

        return new CursoSecundarioDTO(cursoSec.CursoSecundarioCodigo.StringValue,
            cursoSec.CursoSecundarioNome.NomeCursoSecundario);
    }

    public async Task<List<CursoSecundarioDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<CursoSecundarioDTO> listDto = list.ConvertAll(cursoSec => new CursoSecundarioDTO(
            cursoSec.CursoSecundarioCodigo.StringValue,
            cursoSec.CursoSecundarioNome.NomeCursoSecundario));

        return listDto;
    }

    public async Task<CursoSecundarioDTO> GetByCursoCodigoSec(Identifier codigo)
    {
        var dto = await _repo.GetByCodCursoSec(codigo.IntValue);

        return new CursoSecundarioDTO(
            dto.CursoSecundarioCodigo.StringValue,
            dto.CursoSecundarioNome.NomeCursoSecundario);
    }

    public async Task<CursoSecundarioDTO> AddAsync(CursoSecundarioDTO dto)
    {
        var cursoSecundario = new CursoSecundario(dto.CodigoCursoSecundario, dto.NomeCursoSecundario);

        await _repo.AddAsync(cursoSecundario);
        await _unitOfWork.CommitAsync();

        return new CursoSecundarioDTO(
            cursoSecundario.CursoSecundarioCodigo.StringValue,
            cursoSecundario.CursoSecundarioNome.NomeCursoSecundario);
    }

    public async Task<CursoSecundarioDTO> UpdateAsync(CursoSecundarioDTO dto)
    {
        var cursoSecundario = await _repo.GetByIdAsync(new Identifier(dto.CodigoCursoSecundario));

        // change all fields

        cursoSecundario.ChangeCursoSecundarioCodigo(new CursoSecundarioCodigo(dto.CodigoCursoSecundario));
        cursoSecundario.ChangeCursoSecundarioNome(new CursoSecundarioNome(dto.NomeCursoSecundario));

        await _unitOfWork.CommitAsync();

        return new CursoSecundarioDTO(
            cursoSecundario.CursoSecundarioCodigo.StringValue,
            cursoSecundario.CursoSecundarioNome.NomeCursoSecundario);
    }


    public async Task<CursoSecundarioDTO> InactivateAsync(Identifier id)
    {
        var cursoSecundario = await _repo.GetByIdAsync(id);

        if (cursoSecundario == null)
            return null;

        cursoSecundario.MarkAsInactive();

        await _unitOfWork.CommitAsync();

        return new CursoSecundarioDTO(
            cursoSecundario.CursoSecundarioCodigo.StringValue,
            cursoSecundario.CursoSecundarioNome.NomeCursoSecundario);
    }

    public async Task<CursoSecundarioDTO> DeleteAsync(Identifier id)
    {
        var cursoSecundario = await _repo.GetByIdAsync(id);

        if (cursoSecundario == null)
            return null;

        _repo.Remove(cursoSecundario);
        await _unitOfWork.CommitAsync();

        return new CursoSecundarioDTO(
            cursoSecundario.CursoSecundarioCodigo.StringValue,
            cursoSecundario.CursoSecundarioNome.NomeCursoSecundario);
    }
}