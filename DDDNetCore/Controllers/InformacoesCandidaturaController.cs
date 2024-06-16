using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.InformacoesCandidatura;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InformacoesCandidaturaController:ControllerBase
{
     private readonly IInformacoesCandidaturaService _service;

    public InformacoesCandidaturaController(IInformacoesCandidaturaService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<InformacoesCandidaturaDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<InformacoesCandidaturaDTO>> GetById(Identifier id)
    {
        var informacoesDto = await _service.GetByIdAsync(id);

        if (informacoesDto == null)
        {
            return NotFound();
        }

        return informacoesDto;
    }
    
    [HttpGet("{candidatura}")]
    public async Task<ActionResult<InformacoesCandidaturaDTO>> GetByCandidaturaId(Identifier candidatura)
    {
        var informacoesDto = await _service.GetByCandidaturaId(candidatura);

        if (informacoesDto == null)
        {
            return NotFound();
        }

        return informacoesDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<InformacoesCandidaturaDTO>> Create(InformacoesCandidaturaDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var informacoesDto in list)
            {
                if (informacoesDto.Id.Equals(dto.Id))
                {
                    return BadRequest(new
                        { Message = "Já existem informações para a Candidatura mencionada." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var informacoesDto = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = informacoesDto.Id }, informacoesDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<InformacoesCandidaturaDTO>> Update(Identifier id, InformacoesCandidaturaDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.IntValue;

        try
        {
            var informacoesDto = await _service.UpdateAsync(dto);

            if (informacoesDto == null)
            {
                return NotFound();
            }

            return Ok(informacoesDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<InformacoesCandidaturaDTO>> SoftDelete(Identifier id)
    {
        var informacoesDto = await _service.InactivateAsync(id);

        if (informacoesDto == null)
        {
            return NotFound();
        }

        return Ok(informacoesDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<InformacoesCandidaturaDTO>> HardDelete(Identifier id)
    {
        try
        {
            var informacoesDto = await _service.DeleteAsync(id);

            if (informacoesDto == null)
            {
                return NotFound();
            }

            return Ok(informacoesDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}