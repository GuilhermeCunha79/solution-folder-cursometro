using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Escola;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

public class EscolaController:ControllerBase
{
        private readonly IEscolaService _service;

    public EscolaController(IEscolaService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<EscolaDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<EscolaDTO>> GetById(Identifier id)
    {
        var distritoDto = await _service.GetByIdAsync(id);

        if (distritoDto == null)
        {
            return NotFound();
        }

        return distritoDto;
    }
    
    // GET: api/Jogadores/5
    [HttpGet("{distrito}")]
    public async Task<ActionResult<IEnumerable<EscolaDTO>>> GetById(string distrito)
    {
        var escolaDto = await _service.GetByDistrito(distrito);

        return escolaDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<EscolaDTO>> Create(EscolaDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var escolaDto in list)
            {
                if (escolaDto.Id.Equals(dto.Id))
                {
                    return BadRequest(new
                        { Message = "Já existe uma 'Escola' registada com uma das informações fornecidas." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var escola = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = escola.Id }, escola);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<EscolaDTO>> Update([FromRoute] Identifier id, [FromBody] EscolaDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.IntValue;

        try
        {
            var escola = await _service.UpdateAsync(dto);

            if (escola == null)
            {
                return NotFound();
            }

            return Ok(escola);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<EscolaDTO>> SoftDelete(Identifier id)
    {
        var escola = await _service.InactivateAsync(id);

        if (escola == null)
        {
            return NotFound();
        }

        return Ok(escola);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<EscolaDTO>> HardDelete(Identifier id)
    {
        try
        {
            var escola = await _service.DeleteAsync(id);

            if (escola == null)
            {
                return NotFound();
            }

            return Ok(escola);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}