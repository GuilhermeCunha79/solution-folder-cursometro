using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Distrito;
using WebApplication1.Domain.Media;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

public class MediaController : ControllerBase
{
     private readonly IMediaService _service;

    public MediaController(IMediaService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MediaDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<MediaDTO>> GetById(Identifier id)
    {
        var mediaDto = await _service.GetByIdAsync(id);

        if (mediaDto == null)
        {
            return NotFound();
        }

        return mediaDto;
    }
    
    [HttpGet("{utilizadorId}")]
    public async Task<ActionResult<MediaDTO>> GetByUtilizadorId(Identifier utilizadorId)
    {
        var mediaDto = await _service.GetByUtilizadorId(utilizadorId);

        if (mediaDto == null)
        {
            return NotFound();
        }

        return mediaDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<MediaDTO>> Create(MediaDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var mediaDto1 in list)
            {
                if (mediaDto1.UtilizadorId.Equals(dto.Id))
                {
                    return BadRequest(new
                        { Message = "Já existe uma média associada ao presente Utilizador. Tente atualizar a mesma no seu perfil." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var mediaDto = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = mediaDto.Id }, mediaDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<MediaDTO>> Update(Identifier id, MediaDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.IntValue;

        try
        {
            var mediaDto = await _service.UpdateAsync(dto);

            if (mediaDto == null)
            {
                return NotFound();
            }

            return Ok(mediaDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<MediaDTO>> SoftDelete(Identifier id)
    {
        var mediaDto = await _service.InactivateAsync(id);

        if (mediaDto == null)
        {
            return NotFound();
        }

        return Ok(mediaDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<MediaDTO>> HardDelete(Identifier id)
    {
        try
        {
            var mediaDto = await _service.DeleteAsync(id);

            if (mediaDto == null)
            {
                return NotFound();
            }

            return Ok(mediaDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}