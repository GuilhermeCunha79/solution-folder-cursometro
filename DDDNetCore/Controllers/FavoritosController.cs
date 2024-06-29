using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Favoritos;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FavoritosController : ControllerBase
{
    private readonly IFavoritosService _service;

    public FavoritosController(IFavoritosService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FavoritosDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<FavoritosDTO>> GetById(Identifier id)
    {
        var exameDto = await _service.GetByIdAsync(id);

        if (exameDto == null)
        {
            return NotFound();
        }

        return exameDto;
    }
    
    [HttpGet("{idUtilizador}")]
    public async Task<ActionResult<IEnumerable<FavoritosDTO>>> GetByUtilizadorId(Identifier idUtilizador)
    {
        var exameDto = await _service.GetByUtilizadorId(idUtilizador);

        if (exameDto == null)
        {
            return NotFound();
        }

        return exameDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<FavoritosDTO>> Create(FavoritosDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var favoritosDto in list)
            {
                if (favoritosDto.InstituicaoCursoCodigo.Equals(dto.InstituicaoCursoCodigo) &&
                    favoritosDto.IdUtilizador.Equals(dto.IdUtilizador))
                {
                    return BadRequest(new
                        { Message = "Já tem esta instituição adicionada como favorita." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var favoritosDto = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = favoritosDto.Id }, favoritosDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<FavoritosDTO>> Update([FromRoute] Identifier id, [FromBody]FavoritosDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.IntValue;

        try
        {
            var favoritosDto = await _service.UpdateAsync(dto);

            if (favoritosDto == null)
            {
                return NotFound();
            }

            return Ok(favoritosDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<FavoritosDTO>> HardDelete(Identifier id)
    {
        try
        {
            var favoritosDto = await _service.DeleteAsync(id);

            if (favoritosDto == null)
            {
                return NotFound();
            }

            return Ok(favoritosDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}