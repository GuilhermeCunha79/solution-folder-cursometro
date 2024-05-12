using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Curso;
using WebApplication1.Shared;

namespace ConsoleApp1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CursoController : ControllerBase
{
    private readonly ICursoService _service;

    public CursoController(ICursoService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CursoDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<CursoDTO>> GetById(Guid id)
    {
        var jogador = await _service.GetByIdAsync(new Identifier(id));

        if (jogador == null)
        {
            return NotFound();
        }

        return jogador;
    }

    // GET: api/Warehouses/ById/5M4
    [HttpGet("ByIdentifier/{licenca}")]
    public async Task<ActionResult<CursoDTO>> GetByCodClube(string licenca)
    {
        var jogador = await _service.GetByCursoCodigo(licenca);

        if (jogador == null)
        {
            return NotFound();
        }

        return jogador;
    }

    [HttpGet("NomeClube/{licenca}")]
    public async Task<ActionResult<CursoDTO>> GetByNomeClube(string licenca)
    {
        var jogador = await _service.GetByCursoCodigo(licenca);

        if (jogador == null)
        {
            return NotFound();
        }

        return jogador;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<CursoDTO>> Create(CursoDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var jogadorDto in list)
            {
                if (jogadorDto.CodigoCurso.Equals(dto.CodigoCurso))
                {
                    return BadRequest(new
                        { Message = "Já existe um 'Clube' registado com este 'Código'." });
                }
            }
        }

        dto.CodigoCurso = dto.CodigoCurso;
        try
        {
            var jogador = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = jogador.CodigoCurso }, jogador);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    
    
}