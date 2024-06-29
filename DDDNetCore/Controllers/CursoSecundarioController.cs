using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.CursoSecundario;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CursoSecundarioController : ControllerBase
{
    private readonly ICursoSecundarioService _service;

    public CursoSecundarioController(ICursoSecundarioService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CursoSecundarioDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CursoSecundarioDTO>> GetById(Identifier id)
    {
        var cursoSecundarioDto = await _service.GetByIdAsync(id);

        if (cursoSecundarioDto == null)
        {
            return NotFound();
        }

        return cursoSecundarioDto;
    }

    [HttpGet("CursoSec/{cursoSecCod}")]
    public async Task<ActionResult<CursoSecundarioDTO>> GetByCursoCodigoSec(Identifier cursoSecCod)
    {
        var cifDto = await _service.GetByCursoCodigoSec(cursoSecCod);

        if (cifDto == null)
        {
            return NotFound();
        }

        return cifDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<CursoSecundarioDTO>> Create(CursoSecundarioDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var cifDto in list)
            {
                if (cifDto.CodigoCursoSecundario.Equals(dto.CodigoCursoSecundario))
                {
                    return BadRequest(new
                        { Message = "Já existe um curso secundário com o presente código." });
                }
            }
        }

        dto.CodigoCursoSecundario = dto.CodigoCursoSecundario;
        try
        {
            var jogador = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = jogador.CodigoCursoSecundario }, jogador);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<CursoSecundarioDTO>> Update([FromRoute] Identifier id, [FromBody] CursoSecundarioDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.CodigoCursoSecundario = id.StringValue;

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
    public async Task<ActionResult<CursoSecundarioDTO>> SoftDelete(Identifier id)
    {
        var candidatura = await _service.InactivateAsync(id);

        if (candidatura == null)
        {
            return NotFound();
        }

        return Ok(candidatura);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<CursoSecundarioDTO>> HardDelete(Identifier id)
    {
        try
        {
            var candidatura = await _service.DeleteAsync(id);

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
}