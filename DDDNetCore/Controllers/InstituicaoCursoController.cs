using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

public class InstituicaoCursoController:ControllerBase
{
     private readonly IInstituicao_CursoService _service;

    public InstituicaoCursoController(IInstituicao_CursoService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Instituicao_CursoDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Instituicao_CursoDTO>> GetById(Identifier id)
    {
        var instituicaoCursoDto = await _service.GetByIdAsync(id);

        if (instituicaoCursoDto == null)
        {
            return NotFound();
        }

        return instituicaoCursoDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<Instituicao_CursoDTO>> Create(Instituicao_CursoDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var distritoDto in list)
            {
                if (distritoDto.Id.Equals(dto.Id))
                {
                    return BadRequest(new
                        { Message = "Já existe um Curso sob esta Instituição registado com uma das informações fornecidas." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var instituicaoCursoDto = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = instituicaoCursoDto.Id }, instituicaoCursoDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Instituicao_CursoDTO>> Update(Identifier id, Instituicao_CursoDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.StringValue;

        try
        {
            var instituicaoCursoDto = await _service.UpdateAsync(dto);

            if (instituicaoCursoDto == null)
            {
                return NotFound();
            }

            return Ok(instituicaoCursoDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Instituicao_CursoDTO>> SoftDelete(Identifier id)
    {
        var instituicaoCursoDto = await _service.InactivateAsync(id);

        if (instituicaoCursoDto == null)
        {
            return NotFound();
        }

        return Ok(instituicaoCursoDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<Instituicao_CursoDTO>> HardDelete(Identifier id)
    {
        try
        {
            var instituicaoCursoDto = await _service.DeleteAsync(id);

            if (instituicaoCursoDto == null)
            {
                return NotFound();
            }

            return Ok(instituicaoCursoDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}