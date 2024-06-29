using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Instituicao_Ranking;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

public class InstituicaoRankingController:ControllerBase
{
     private readonly IInstituicaoRankingService _service;

    public InstituicaoRankingController(IInstituicaoRankingService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Instituicao_RankingDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Instituicao_RankingDTO>> GetById(Identifier id)
    {
        var instituicaoDto = await _service.GetByIdAsync(id);

        if (instituicaoDto == null)
        {
            return NotFound();
        }

        return instituicaoDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<Instituicao_RankingDTO>> Create(Instituicao_RankingDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var instituicaoDto in list)
            {
                if (instituicaoDto.IdRanking.Equals(dto.IdRanking) && instituicaoDto.CodigoInstituicao.Equals(dto.CodigoInstituicao))
                {
                    return BadRequest(new
                        { Message = "O 'Ranking' selecionado já se encontra ssociado a esta 'Instituição'." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var distrito = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = distrito.Id }, distrito);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Instituicao_RankingDTO>> Update([FromRoute] Identifier id,[FromBody] Instituicao_RankingDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.IntValue;

        try
        {
            var instituicaoDto = await _service.UpdateAsync(dto);

            if (instituicaoDto == null)
            {
                return NotFound();
            }

            return Ok(instituicaoDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Instituicao_RankingDTO>> SoftDelete(Identifier id)
    {
        var instituicaoDto = await _service.InactivateAsync(id);

        if (instituicaoDto == null)
        {
            return NotFound();
        }

        return Ok(instituicaoDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<Instituicao_RankingDTO>> HardDelete(Identifier id)
    {
        try
        {
            var instituicaoDto = await _service.DeleteAsync(id);

            if (instituicaoDto == null)
            {
                return NotFound();
            }

            return Ok(instituicaoDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}