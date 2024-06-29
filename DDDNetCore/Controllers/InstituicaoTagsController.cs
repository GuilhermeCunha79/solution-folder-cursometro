using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Domain.Instituicao_Tags;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

public class InstituicaoTagsController:ControllerBase
{
     private readonly IInstituicao_TagsService _service;

    public InstituicaoTagsController(IInstituicao_TagsService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Instituicao_TagsDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Instituicao_TagsDTO>> GetById(Identifier id)
    {
        var instituicaoTagsDto = await _service.GetByIdAsync(id);

        if (instituicaoTagsDto == null)
        {
            return NotFound();
        }

        return instituicaoTagsDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<Instituicao_TagsDTO>> Create(Instituicao_TagsDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var distritoDto in list)
            {
                if (distritoDto.IdTag.Equals(dto.IdTag) || distritoDto.CodigoInstituicao.Equals(dto.CodigoInstituicao))
                {
                    return BadRequest(new
                        { Message = "A Tag selecionada já se encontra associada a esta Instituição." });
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
    public async Task<ActionResult<Instituicao_TagsDTO>> Update([FromRoute] Identifier id,[FromBody] Instituicao_TagsDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.IntValue;

        try
        {
            var instituicaoTagsDto = await _service.UpdateAsync(dto);

            if (instituicaoTagsDto == null)
            {
                return NotFound();
            }

            return Ok(instituicaoTagsDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Instituicao_TagsDTO>> SoftDelete(Identifier id)
    {
        var instituicaoTagsDto = await _service.InactivateAsync(id);

        if (instituicaoTagsDto == null)
        {
            return NotFound();
        }

        return Ok(instituicaoTagsDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<Instituicao_TagsDTO>> HardDelete(Identifier id)
    {
        try
        {
            var instituicaoTagsDto = await _service.DeleteAsync(id);

            if (instituicaoTagsDto == null)
            {
                return NotFound();
            }

            return Ok(instituicaoTagsDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}