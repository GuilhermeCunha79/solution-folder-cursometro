using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Curso_Tags;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Curso_TagsController : ControllerBase
{
    private readonly ICurso_TagsService _service;

    public Curso_TagsController(ICurso_TagsService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Curso_TagsDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Curso_TagsDTO>> GetById(Identifier id)
    {
        var cif = await _service.GetByIdAsync(id);

        if (cif == null)
        {
            return NotFound();
        }

        return cif;
    }

    [HttpGet("{codigo}/{tagId}")]
    public async Task<List<Curso_TagsDTO>> GetByCursoCodigoTagId(Identifier codigo, Identifier tagId)
    {
        var list = await _service.GetByCursoCodigoTagId(codigo, tagId);

        List<Curso_TagsDTO> listDto = list.ConvertAll(cursoTags => new Curso_TagsDTO(cursoTags.Id,
            cursoTags.IdTag, cursoTags.CodigoCurso));

        return listDto;
    }


    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<Curso_TagsDTO>> Create(Curso_TagsDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var cursoTagsDto in list)
            {
                if (cursoTagsDto.CodigoCurso.Equals(dto.CodigoCurso) && cursoTagsDto.IdTag.Equals(dto.IdTag))
                {
                    return BadRequest(new
                        { Message = "Já existe um conjunto de 'Curso' e 'Tag'registado com estas informações." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var candidatura = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = candidatura.Id }, candidatura);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}