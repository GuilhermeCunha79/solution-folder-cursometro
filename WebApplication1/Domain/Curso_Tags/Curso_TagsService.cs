using WebApplication1.Infrastructure;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso_Tags;

public class Curso_TagsService : ICurso_TagsService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurso_TagsRepository _repo;

    public Curso_TagsService(IUnitOfWork unitOfWork, ICurso_TagsRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<Curso_TagsDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<Curso_TagsDTO> listDto = list.ConvertAll(cursoTags => new Curso_TagsDTO(cursoTags.Id, cursoTags.TagId,
            cursoTags.CursoCodigo));

        return listDto;
    }

    public async Task<Curso_TagsDTO> GetByIdAsync(Identifier id)
    {
        var cursoTags = await _repo.GetByIdAsync(id);

        return new Curso_TagsDTO(cursoTags.Id, cursoTags.TagId, cursoTags.CursoCodigo);
    }

    public async Task<List<Curso_TagsDTO>> GetByCursoCodigoTagId(string codigo, Identifier tagId)
    {
        var list = await _repo.GetByCursoCodigoTagId(codigo, tagId);

        List<Curso_TagsDTO> dtoList = list.ConvertAll(cursoTags => new Curso_TagsDTO(cursoTags.Id, cursoTags.TagId,
            cursoTags.CursoCodigo));

        return dtoList;
    }

    public async Task<Curso_TagsDTO> AddAsync(Curso_TagsDTO dto)
    {
        var cursoTags = new Curso_Tags(dto.IdTag.IntValue, dto.CodigoCurso.StringValue);

        await _repo.AddAsync(cursoTags);
        await _unitOfWork.CommitAsync();

        return new Curso_TagsDTO(cursoTags.Id, cursoTags.TagId, cursoTags.CursoCodigo);
    }
    
    
}