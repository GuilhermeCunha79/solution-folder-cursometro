using WebApplication1.Shared;

namespace WebApplication1.Domain.InformacoesCandidatura;

public class InformacoesCandidaturaService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IInformacoesCandidaturaRepository _repo;

    public InformacoesCandidaturaService(IUnitOfWork unitOfWork, IInformacoesCandidaturaRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<InformacoesCandidaturaDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<InformacoesCandidaturaDTO> listDto = list.ConvertAll(informacoes =>
            new InformacoesCandidaturaDTO(informacoes.Id.IntValue, informacoes.NotaEntradaValor.ValorNotaEntrada,
                informacoes.VagasNumero.NumeroVagas,
                informacoes.IdCandidatura.IntValue));

        return listDto;
    }

    public async Task<InformacoesCandidaturaDTO> GetByIdAsync(Identifier id)
    {
        var informacoes = await _repo.GetByIdAsync(id);

        return new InformacoesCandidaturaDTO(informacoes.Id.IntValue, informacoes.NotaEntradaValor.ValorNotaEntrada,
            informacoes.VagasNumero.NumeroVagas,
            informacoes.IdCandidatura.IntValue);
    }

    public async Task<InformacoesCandidaturaDTO> AddAsync(InformacoesCandidaturaDTO dto)
    {
        var informacoes = new InformacoesCandidatura(dto.NotaEntrada, dto.NrVagas, dto.CandidaturaId);

        await _repo.AddAsync(informacoes);

        await _unitOfWork.CommitAsync();

        return new InformacoesCandidaturaDTO(informacoes.Id.IntValue, informacoes.NotaEntradaValor.ValorNotaEntrada,
            informacoes.VagasNumero.NumeroVagas,
            informacoes.IdCandidatura.IntValue);
    }

    public async Task<InformacoesCandidaturaDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<InformacoesCandidaturaDTO> DeleteAsync(Identifier id)
    {
        var informacoes = await _repo.GetByIdAsync(id);

        if (informacoes == null)
            return null;

        _repo.Remove(informacoes);
        await _unitOfWork.CommitAsync();

        return new InformacoesCandidaturaDTO(informacoes.Id.IntValue, informacoes.NotaEntradaValor.ValorNotaEntrada,
            informacoes.VagasNumero.NumeroVagas,
            informacoes.IdCandidatura.IntValue);
    }

    public async Task<InformacoesCandidaturaDTO> UpdateAsync(InformacoesCandidaturaDTO dto)
    {
        var informacoes = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new InformacoesCandidaturaDTO(informacoes.Id.IntValue, informacoes.NotaEntradaValor.ValorNotaEntrada,
            informacoes.VagasNumero.NumeroVagas,
            informacoes.IdCandidatura.IntValue);
    }
}