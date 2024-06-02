using ConsoleApp1.Domain.Cif;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Shared;

namespace ConsoleApp1.Controllers;

public class CifController : ControllerBase
{
    private readonly ICifService _service;

    public CifController(ICifService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CifDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<CifDTO>> GetById(Guid id)
    {
        var cif = await _service.GetByIdAsync(new Identifier(id));

        if (cif == null)
        {
            return NotFound();
        }

        return cif;
    }
    
    [HttpGet("Utilizador/{utilizadorId}")]
    public async Task<ActionResult<CifDTO>> GetByUtilizadorId(Guid utilizadorId)
    {
        var cifDto = await _service.GetByUtilizadorId(new Identifier(utilizadorId));

        if (cifDto == null)
        {
            return NotFound();
        }

        return cifDto;
    }
    
    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<CifDTO>> Create(CifDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var cifDto in list)
            {
                if (cifDto.UtilizadorId.Equals(dto.UtilizadorId))
                {
                    return BadRequest(new
                        { Message = "Já existe um conjunto de notas associado ao presente utilizador." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var jogador = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = jogador.Id }, jogador);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}