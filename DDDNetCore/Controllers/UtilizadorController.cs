using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Utilizador;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

public class UtilizadorController:ControllerBase
{
     private readonly IUtilizadorService _service;

    public UtilizadorController(IUtilizadorService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<UtilizadorDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<UtilizadorDTO>> GetById(Identifier id)
    {
        var utilizadorDto = await _service.GetByIdAsync(id);

        if (utilizadorDto == null)
        {
            return NotFound();
        }

        return utilizadorDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<UtilizadorDTO>> Create(UtilizadorDTO dto)
    {
        /*var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var utilizadorDto in list)
            {
                if (distritoDto.Id.Equals(dto.Id) || distritoDto.Distrito.Equals(dto.Distrito))
                {
                    return BadRequest(new
                        { Message = "Já existe um 'Distrito' registada com uma das informações fornecidas." });
                }
            }
        }*/

        dto.Id = dto.Id;
        try
        {
            var utilizadorDto = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = utilizadorDto.Id }, utilizadorDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UtilizadorDTO>> Update([FromRoute] Identifier id,[FromBody] UtilizadorDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.StringValue;

        try
        {
            var utilizadorDto = await _service.UpdateAsync(dto);

            if (utilizadorDto == null)
            {
                return NotFound();
            }

            return Ok(utilizadorDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<UtilizadorDTO>> SoftDelete(Identifier id)
    {
        var utilizadorDto = await _service.InactivateAsync(id);

        if (utilizadorDto == null)
        {
            return NotFound();
        }

        return Ok(utilizadorDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<UtilizadorDTO>> HardDelete(Identifier id)
    {
        try
        {
            var utilizadorDto = await _service.DeleteAsync(id);

            if (utilizadorDto == null)
            {
                return NotFound();
            }

            return Ok(utilizadorDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}