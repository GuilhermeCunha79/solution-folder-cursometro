using WebApplication1.Domain.Tags;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador;

public class UtilizadorService : IUtilizadorService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUtilizadorRepository _repo;

    public UtilizadorService(IUnitOfWork unitOfWork, IUtilizadorRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<UtilizadorDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<UtilizadorDTO> listDto = list.ConvertAll(utilizador =>
            new UtilizadorDTO(utilizador.Id.StringValue, utilizador.UtilizadorNome.NomeUtilizador,
                utilizador.UtilizadorAno.AnoUtilizador, utilizador.UtilizadorIdade.IdadeUtilizador,
                utilizador.UtilizadorPassword.Password, utilizador.EscolaId.IntValue));

        return listDto;
    }

    public async Task<UtilizadorDTO> GetByIdAsync(Identifier id)
    {
        var utilizador = await _repo.GetByIdAsync(id);

        return new UtilizadorDTO(utilizador.Id.StringValue, utilizador.UtilizadorNome.NomeUtilizador,
            utilizador.UtilizadorAno.AnoUtilizador, utilizador.UtilizadorIdade.IdadeUtilizador,
            utilizador.UtilizadorPassword.Password, utilizador.EscolaId.IntValue);
    }


    public async Task<UtilizadorDTO> AddAsync(UtilizadorDTO dto)
    {
        var utilizador = new Utilizador(dto.IdEscola, dto.Idade, dto.Nome, dto.Password, dto.Ano);

        await _repo.AddAsync(utilizador);

        await _unitOfWork.CommitAsync();

        return new UtilizadorDTO(utilizador.Id.StringValue, utilizador.UtilizadorNome.NomeUtilizador,
            utilizador.UtilizadorAno.AnoUtilizador, utilizador.UtilizadorIdade.IdadeUtilizador,
            utilizador.UtilizadorPassword.Password, utilizador.EscolaId.IntValue);
    }

    public async Task<UtilizadorDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<UtilizadorDTO> DeleteAsync(Identifier id)
    {
        var utilizador = await _repo.GetByIdAsync(id);

        if (utilizador == null)
            return null;

        _repo.Remove(utilizador);
        await _unitOfWork.CommitAsync();

        return new UtilizadorDTO(utilizador.Id.StringValue, utilizador.UtilizadorNome.NomeUtilizador,
            utilizador.UtilizadorAno.AnoUtilizador, utilizador.UtilizadorIdade.IdadeUtilizador,
            utilizador.UtilizadorPassword.Password, utilizador.EscolaId.IntValue);
    }

    public async Task<UtilizadorDTO> UpdateAsync(UtilizadorDTO dto)
    {
        var utilizador = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new UtilizadorDTO(utilizador.Id.StringValue, utilizador.UtilizadorNome.NomeUtilizador,
            utilizador.UtilizadorAno.AnoUtilizador, utilizador.UtilizadorIdade.IdadeUtilizador,
            utilizador.UtilizadorPassword.Password, utilizador.EscolaId.IntValue);
    }
}