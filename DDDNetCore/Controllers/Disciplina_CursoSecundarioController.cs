using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Disciplina_CursoSecundario;
using WebApplication1.Domain.NotaVisualizacao;
using WebApplication1.Shared;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Disciplina_CursoSecundarioController : ControllerBase
{
    private readonly IDisciplina_CursoSecundarioService _service;

    public Disciplina_CursoSecundarioController(IDisciplina_CursoSecundarioService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Disciplina_CursoSecundarioDTO>>> GetAll()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Disciplina_CursoSecundarioDTO>> GetById(Identifier id)
    {
        var disciplinaCurso = await _service.GetByIdAsync(id);

        if (disciplinaCurso == null)
        {
            return NotFound();
        }

        return disciplinaCurso;
    }

    [HttpGet("DisciplinaCurso/{utilizadorId}")]
    public async Task<ActionResult<List<Disciplina_CursoSecundarioDTO>>> GetByUtilizadorId(string utilizadorId)
    {
        var disciplinaDto = await _service.GetByUtilizadorId(utilizadorId);

        if (disciplinaDto == null)
        {
            return NotFound();
        }

        return disciplinaDto;
    }

    [HttpGet("UtilizadorDisciplinaCurso/{utilizadorId}/{disciplinaCod}")]
    public async Task<ActionResult<Disciplina_CursoSecundarioDTO>> GetByUtilizadorDisciplina(
        [FromRoute] string utilizadorId,[FromRoute] string disciplinaCod)
    {
        var disciplinaDto = await _service.GetByUtilizadorDisciplina(utilizadorId,disciplinaCod);

        if (disciplinaDto == null)
        {
            return NotFound();
        }

        return disciplinaDto;
    }

    // POST: api/Jogadores
    [HttpPost]
    public async Task<ActionResult<IEnumerable<Disciplina_CursoSecundarioDTO>>> Create(NotaVisualizacaoDTO dto)
    {
        var list = await _service.GetAllAsync();

        if (list != null)
        {
            foreach (var disciplinaCursoDto in list)
            {
                if (disciplinaCursoDto.UtilizadorId.Equals(dto.IdUtilizador))
                {
                    return BadRequest(new
                    {
                        Message = "Já existe um conjunto de notas associado ao presente utilizador. Tente atualizar"
                    });
                }
            }
        }

        try
        {
            var disciplinas = await _service.AddAsync(dto);
            // If necessary, you can create individual CreatedAtAction responses for each element in the list.
            // However, typically, you'd just return the list of created items directly.
            return Created("", disciplinas); // 201 Created with the list of items
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }


    [HttpPut("{id}")]
    public async Task<ActionResult<Disciplina_CursoSecundarioDTO>> Update([FromRoute] Identifier id,
        [FromBody] Disciplina_CursoSecundarioDTO dto)
    {
        dto.Id = id.StringValue;

        try
        {
            var candidatura = await _service.UpdateAsync(dto);

            if (candidatura == null)
            {
                return NotFound();
            }

            return Ok(candidatura);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    // Inactivate: api/Deliveries/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Disciplina_CursoSecundarioDTO>> SoftDelete(Identifier id)
    {
        var disciplinaDto = await _service.InactivateAsync(id);

        if (disciplinaDto == null)
        {
            return NotFound();
        }

        return Ok(disciplinaDto);
    }

    // DELETE: api/Deliveries/5
    [HttpDelete("{id}/hard")]
    public async Task<ActionResult<Disciplina_CursoSecundarioDTO>> HardDelete(Identifier id)
    {
        try
        {
            var disciplinaDto = await _service.DeleteAsync(id);

            if (disciplinaDto == null)
            {
                return NotFound();
            }

            return Ok(disciplinaDto);
        }
        catch (BusinessRuleValidationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}