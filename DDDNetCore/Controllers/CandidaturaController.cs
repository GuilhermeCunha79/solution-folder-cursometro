using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Candidatura;
using WebApplication1.Shared;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidaturaController : ControllerBase
    {
        private readonly ICandidaturaService _service;

        public CandidaturaController(ICandidaturaService service)
        {
            _service = service;
        }

        // GET: api/Jogadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidaturaDTO>>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        // GET: api/Jogadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CandidaturaDTO>> GetById(Identifier id)
        {
            var candidatura = await _service.GetByIdAsync(id);

            if (candidatura == null)
            {
                return NotFound();
            }

            return candidatura;
        }

        // POST: api/Jogadores
        [HttpPost]
        public async Task<ActionResult<CandidaturaDTO>> Create(CandidaturaDTO dto)
        {
            var list = await _service.GetAllAsync();

            if (list != null)
            {
                foreach (var candidaturaDto in list)
                {
                    if (candidaturaDto.Ano.Equals(dto.Ano)
                        && candidaturaDto.Fase.Equals(dto.Fase) &&
                        candidaturaDto.InstituicaoCursoCodigo.Equals(dto.InstituicaoCursoCodigo))
                    {
                        return BadRequest(new
                            { Message = "Já existe uma 'Candidatura' registada com as informações fornecidas." });
                    }
                }
            }

            dto.Id = dto.Id;
            try
            {
                var candidatura = await _service.AddAsync(dto);

                return CreatedAtAction(nameof(GetById), new { id = candidatura.Id }, candidatura);
            }
            catch (BusinessRuleValidationException ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CandidaturaDTO>> Update([FromRoute] Identifier id, [FromBody] CandidaturaDTO dto)
        {
            // if (id != dto.Id)
            // {
            //     return BadRequest();
            // }

            dto.Id = id.IntValue;

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
        public async Task<ActionResult<CandidaturaDTO>> SoftDelete(Identifier id)
        {
            var candidatura = await _service.InactivateAsync(id);

            if (candidatura == null)
            {
                return NotFound();
            }

            return Ok(candidatura);
        }

        // DELETE: api/Deliveries/5
        [HttpDelete("{id}/hard")]
        public async Task<ActionResult<CandidaturaDTO>> HardDelete(Identifier id)
        {
            try
            {
                var candidatura = await _service.DeleteAsync(id);

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
    }
}