using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Distrito;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DistritoController : ControllerBase
{
    private readonly IDistritoService _service;

    public DistritoController(IDistritoService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<DistritoDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<DistritoDTO>> GetById(Identifier id)
    {
        var distritoDto = await _service.GetByIdAsync(id);

        if (distritoDto == null)
        {
            return NotFound();
        }

        return distritoDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<DistritoDTO>> Create(DistritoDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var distritoDto in list)
            {
                if (distritoDto.Id.Equals(dto.Id) || distritoDto.Distrito.Equals(dto.Distrito))
                {
                    return BadRequest(new
                        { Message = "Já existe um 'Distrito' registada com uma das informações fornecidas." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var distrito = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = distrito.Id }, distrito);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<DistritoDTO>> Update([FromRoute] Identifier id, [FromBody]DistritoDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.StringValue;

        try
        {
            var distrito = await _service.UpdateAsync(dto);

            if (distrito == null)
            {
                return NotFound();
            }

            return Ok(distrito);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<DistritoDTO>> SoftDelete(Identifier id)
    {
        var distrito = await _service.InactivateAsync(id);

        if (distrito == null)
        {
            return NotFound();
        }

        return Ok(distrito);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<DistritoDTO>> HardDelete(Identifier id)
    {
        try
        {
            var distritoDto = await _service.DeleteAsync(id);

            if (distritoDto == null)
            {
                return NotFound();
            }

            return Ok(distritoDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}