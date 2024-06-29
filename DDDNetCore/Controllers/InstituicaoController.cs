using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

public class InstituicaoController : ControllerBase
{
    private readonly IInstituicaoService _service;

    public InstituicaoController(IInstituicaoService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<InstituicaoDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<InstituicaoDTO>> GetById(Identifier id)
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
    public async Task<ActionResult<InstituicaoDTO>> Create(InstituicaoDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var instituicaoDto in list)
            {
                if (instituicaoDto.Codigo.Equals(dto.Codigo) || instituicaoDto.Nome.Equals(dto.Nome) ||
                    instituicaoDto.Email.Equals(dto.Email) || instituicaoDto.PaginaLink.Equals(dto.PaginaLink))
                {
                    return BadRequest(new
                        { Message = "Já existe uma 'Instituicao' registada com uma das informações fornecidas." });
                }
            }
        }

        dto.Codigo = dto.Codigo;
        try
        {
            var instituicaoDto = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = instituicaoDto.Codigo }, instituicaoDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<InstituicaoDTO>> Update([FromRoute] Identifier id,[FromBody] InstituicaoDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Codigo = id.StringValue;

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
    public async Task<ActionResult<InstituicaoDTO>> SoftDelete(Identifier id)
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
    public async Task<ActionResult<InstituicaoDTO>> HardDelete(Identifier id)
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