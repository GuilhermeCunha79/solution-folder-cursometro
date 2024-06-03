using ConsoleApp1.Domain.CursoSecundario;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Shared;

namespace ConsoleApp1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CursoSecundarioController:ControllerBase
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
    public async Task<ActionResult<CursoSecundarioDTO>> GetById(Guid id)
    {
        var cursoSecundarioDto = await _service.GetByIdAsync(new Identifier(id));

        if (cursoSecundarioDto == null)
        {
            return NotFound();
        }

        return cursoSecundarioDto;
    }
    
    [HttpGet("CursoSec/{cursoSecCod}")]
    public async Task<ActionResult<CursoSecundarioDTO>> GetByCursoCodigoSec(Guid cursoSecCod)
    {
        var cifDto = await _service.GetByCursoCodigoSec(new Identifier(cursoSecCod));

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
    
}