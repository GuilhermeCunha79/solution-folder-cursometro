using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Distrito;
using WebApplication1.Domain.Instituicao_Curso_ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

public class Instituicao_Curso_ExameIngressoController : ControllerBase
{
    private readonly IInstituicao_Curso_ExameIngressoService _service;

    public Instituicao_Curso_ExameIngressoController(IInstituicao_Curso_ExameIngressoService service)
    {
        _service = service;
    }

    // GET: api/Jogadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Instituicao_Curso_ExameIngressoDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    // GET: api/Jogadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Instituicao_Curso_ExameIngressoDTO>> GetById(Identifier id)
    {
        var distritoDto = await _service.GetByIdAsync(id);

        if (distritoDto == null)
        {
            return NotFound();
        }

        return distritoDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<Instituicao_Curso_ExameIngressoDTO>> Create(Instituicao_Curso_ExameIngressoDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var instituicaoCurso in list)
            {
                if (instituicaoCurso.InstituicaoCursoCodigo.Equals(dto.InstituicaoCursoCodigo) &&
                    instituicaoCurso.CodigoExame.Equals(dto.CodigoExame))
                {
                    return BadRequest(new
                        { Message = "O Exame mencionado já se encontra associado a esta Instituição." });
                }
            }
        }

        dto.Id = dto.Id;
        try
        {
            var instituicaoCurso = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = instituicaoCurso.Id }, instituicaoCurso);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Instituicao_Curso_ExameIngressoDTO>> Update([FromRoute] Identifier id,
        [FromBody] Instituicao_Curso_ExameIngressoDTO dto)
    {
        // if (id != dto.Id)
        // {
        //     return BadRequest();
        // }

        dto.Id = id.IntValue;

        try
        {
            var instituicaoCurso = await _service.UpdateAsync(dto);

            if (instituicaoCurso == null)
            {
                return NotFound();
            }

            return Ok(instituicaoCurso);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Instituicao_Curso_ExameIngressoDTO>> SoftDelete(Identifier id)
    {
        var instituicaoCurso = await _service.InactivateAsync(id);

        if (instituicaoCurso == null)
        {
            return NotFound();
        }

        return Ok(instituicaoCurso);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<Instituicao_Curso_ExameIngressoDTO>> HardDelete(Identifier id)
    {
        try
        {
            var instituicaoCurso = await _service.DeleteAsync(id);

            if (instituicaoCurso == null)
            {
                return NotFound();
            }

            return Ok(instituicaoCurso);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}