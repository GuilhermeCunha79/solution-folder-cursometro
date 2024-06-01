using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Candidatura;
using WebApplication1.Shared;

namespace ConsoleApp1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CandidaturaController : ControllerBase
{
        private readonly ICandidaturaService _service;

    public CandidaturaController(ICandidaturaService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CandidaturaDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<CandidaturaDTO>> GetById(Guid id)
    {
        var candidatura = await _service.GetByIdAsync(new Identifier(id));

        if (candidatura == null)
        {
            return NotFound();
        }

        return candidatura;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<CandidaturaDTO>> Create(CandidaturaDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var jogadorDto in list)
            {
                if (jogadorDto.Id.Equals(dto.Id))
                {
                    return BadRequest(new
                        { Message = "Já existe um 'Clube' registado com este 'Código'." });
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