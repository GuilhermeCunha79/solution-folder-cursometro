using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Tags;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TagsController : ControllerBase
{
    private readonly ITagsService _service;

    public TagsController(ITagsService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TagsDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TagsDTO>> GetById(Identifier id)
    {
        var tagsDto = await _service.GetByIdAsync(id);

        if (tagsDto == null)
        {
            return NotFound();
        }

        return tagsDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<TagsDTO>> Create(TagsDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var tagsDto in list)
            {
                if (tagsDto.Nome.Equals(dto.Nome) && tagsDto.Descricao.Equals(dto.Descricao))
                {
                    return BadRequest(new
                        { Message = "Já existe uma 'Tag' registada com as características fornecidas." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var tagsDto = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = tagsDto.Id }, tagsDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<TagsDTO>> Update([FromRoute] Identifier id,[FromBody] TagsDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.IntValue;

        try
        {
            var tagsDto = await _service.UpdateAsync(dto);

            if (tagsDto == null)
            {
                return NotFound();
            }

            return Ok(tagsDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<TagsDTO>> SoftDelete(Identifier id)
    {
        var tagsDto = await _service.InactivateAsync(id);

        if (tagsDto == null)
        {
            return NotFound();
        }

        return Ok(tagsDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<TagsDTO>> HardDelete(Identifier id)
    {
        try
        {
            var tagsDto = await _service.DeleteAsync(id);

            if (tagsDto == null)
            {
                return NotFound();
            }

            return Ok(tagsDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}