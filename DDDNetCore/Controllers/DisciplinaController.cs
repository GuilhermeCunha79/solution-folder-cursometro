using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Disciplina;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DisciplinaController : ControllerBase
{
    private readonly IDisciplinaService _service;

    public DisciplinaController(IDisciplinaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DisciplinaDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DisciplinaDTO>> GetById(Identifier id)
    {
        var cursoSecundarioDto = await _service.GetByIdAsync(id);

        if (cursoSecundarioDto == null)
        {
            return NotFound();
        }

        return cursoSecundarioDto;
    }

    [HttpGet("Disciplina/{disciplinaId}")]
    public async Task<ActionResult<DisciplinaDTO>> GetByCodDisciplina(Identifier disciplinaId)
    {
        var disciplinaDto = await _service.GetByDisciplinaId(disciplinaId);

        if (disciplinaDto == null)
        {
            return NotFound();
        }

        return disciplinaDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<DisciplinaDTO>> Create(DisciplinaDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var cifDto in list)
            {
                if (cifDto.Idd.Equals(dto.Idd))
                {
                    return BadRequest(new
                        { Message = "Já existe uma disciplina com o presente código." });
                }
            }
        }

        dto.Idd = dto.Idd;
        try
        {
            var disciplina = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = disciplina.Idd }, disciplina);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<DisciplinaDTO>> Update([FromRoute] Identifier id, [FromBody] DisciplinaDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Idd = id.StringValue;

        try
        {
            var candidatura = await _service.UpdateAsync(dto);

            if (candidatura == null)
            {
                return NotFound();
            }

            return Ok(candidatura);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<DisciplinaDTO>> SoftDelete(Identifier id)
    {
        var disciplinaDto = await _service.InactivateAsync(id);

        if (disciplinaDto == null)
        {
            return NotFound();
        }

        return Ok(disciplinaDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<DisciplinaDTO>> HardDelete(Identifier id)
    {
        try
        {
            var disciplinaDto = await _service.DeleteAsync(id);

            if (disciplinaDto == null)
            {
                return NotFound();
            }

            return Ok(disciplinaDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}