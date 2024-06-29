using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Ranking;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

public class RankingController : ControllerBase
{
    private readonly IRankingService _service;

    public RankingController(IRankingService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<RankingDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<RankingDTO>> GetById(Identifier id)
    {
        var rankingDto = await _service.GetByIdAsync(id);

        if (rankingDto == null)
        {
            return NotFound();
        }

        return rankingDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<RankingDTO>> Create(RankingDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var rankingDto in list)
            {
                if (rankingDto.NomeRanking.Equals(dto.NomeRanking) &&
                    rankingDto.NacionalBool.Equals(dto.NacionalBool) && rankingDto.Posicao.Equals(dto.Posicao))
                {
                    return BadRequest(new
                        { Message = "Já existe um 'Ranking' com estas características." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var rankingDto = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = rankingDto.Id }, rankingDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<RankingDTO>> Update([FromRoute] Identifier id,[FromBody] RankingDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.IntValue;

        try
        {
            var rankingDto = await _service.UpdateAsync(dto);

            if (rankingDto == null)
            {
                return NotFound();
            }

            return Ok(rankingDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<RankingDTO>> SoftDelete(Identifier id)
    {
        var rankingDto = await _service.InactivateAsync(id);

        if (rankingDto == null)
        {
            return NotFound();
        }

        return Ok(rankingDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<RankingDTO>> HardDelete(Identifier id)
    {
        try
        {
            var rankingDto = await _service.DeleteAsync(id);

            if (rankingDto == null)
            {
                return NotFound();
            }

            return Ok(rankingDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}