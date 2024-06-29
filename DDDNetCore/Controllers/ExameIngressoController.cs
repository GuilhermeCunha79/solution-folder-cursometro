using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Distrito;
using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExameIngressoController : ControllerBase
{
    private readonly IExameIngressoService _service;

    public ExameIngressoController(IExameIngressoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ExameIngressoDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ExameIngressoDTO>> GetById(Identifier id)
    {
        var exameDto = await _service.GetByIdAsync(id);

        if (exameDto == null)
        {
            return NotFound();
        }

        return exameDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<ExameIngressoDTO>> Create(ExameIngressoDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var exameDto in list)
            {
                if (exameDto.CodigoExame.Equals(dto.CodigoExame) || exameDto.NomeExame.Equals(dto.NomeExame))
                {
                    return BadRequest(new
                        { Message = "Já existe um 'Distrito' registada com uma das informações fornecidas." });
                }
            }
        }

        dto.CodigoExame = dto.CodigoExame;
        try
        {
            var exameIngressoDto = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = exameIngressoDto.CodigoExame }, exameIngressoDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ExameIngressoDTO>> Update([FromRoute] Identifier id, [FromBody] ExameIngressoDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.CodigoExame = id.StringValue;

        try
        {
            var exameIngressoDto = await _service.UpdateAsync(dto);

            if (exameIngressoDto == null)
            {
                return NotFound();
            }

            return Ok(exameIngressoDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<ExameIngressoDTO>> SoftDelete(Identifier id)
    {
        var exameIngressoDto = await _service.InactivateAsync(id);

        if (exameIngressoDto == null)
        {
            return NotFound();
        }

        return Ok(exameIngressoDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<ExameIngressoDTO>> HardDelete(Identifier id)
    {
        try
        {
            var exameIngressoDto = await _service.DeleteAsync(id);

            if (exameIngressoDto == null)
            {
                return NotFound();
            }

            return Ok(exameIngressoDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}