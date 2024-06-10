using WebApplication1.Shared;

namespace WebApplication1.Domain.Cif;

public class CifService : ICifService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICifRepository _repo;

    public CifService(IUnitOfWork unitOfWork, ICifRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<CifDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<CifDTO> listDto = list.ConvertAll(cif => new CifDTO(cif.Id.IntValue, cif.CifDisciplina.DisciplinaCif,
            cif.UtilizadorId.IntValue,
            cif.DisciplinaCodigo.StringValue));

        return listDto;
    }

    public async Task<CifDTO> GetByIdAsync(Identifier id)
    {
        var cif = await _repo.GetByIdAsync(id);

        return new CifDTO(cif.Id.IntValue, cif.CifDisciplina.DisciplinaCif,
            cif.UtilizadorId.IntValue,
            cif.DisciplinaCodigo.StringValue);
    }

    public async Task<List<CifDTO>> GetByUtilizadorId(Identifier utilizadorId)
    {
        var cif = await _repo.GetByUtilizador(utilizadorId.IntValue);

        List<CifDTO> listDto = cif.ConvertAll(cif => new CifDTO(cif.Id.IntValue, cif.CifDisciplina.DisciplinaCif,
            cif.UtilizadorId.IntValue, cif.DisciplinaCodigo.StringValue));

        return listDto;
    }

    public async Task<CifDTO> GetByUtilizadorDisciplina(int utilizadorId, string disciplinaId)
    {
        var cif = await _repo.GetByUtilizadorDisciplina(utilizadorId,disciplinaId);

        return new CifDTO(cif.Id.IntValue, cif.CifDisciplina.DisciplinaCif,
            cif.UtilizadorId.IntValue,
            cif.DisciplinaCodigo.StringValue);
    }

    public async Task<CifDTO> AddAsync(CifDTO dto)
    {
        var cif = new Cif(dto.CifDisciplina, dto.UtilizadorId, dto.DisciplinaId);

        await _repo.AddAsync(cif);
        await _unitOfWork.CommitAsync();
        return new CifDTO(cif.Id.IntValue, cif.CifDisciplina.DisciplinaCif,
            cif.UtilizadorId.IntValue,
            cif.DisciplinaCodigo.StringValue);
    }

    public async Task<CifDTO> UpdateAsync(CifDTO dto)
    {
        var cif = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields

        cif.ChangeCifDisciplina(new CifDisciplina(dto.CifDisciplina));

        await _unitOfWork.CommitAsync();

        return new CifDTO(cif.Id.IntValue, cif.CifDisciplina.DisciplinaCif,
            cif.UtilizadorId.IntValue,
            cif.DisciplinaCodigo.StringValue);
    }

    public async Task<CifDTO> UpdateByUtilizadorDisciplinaIdAsync(CifDTO dto)
    {
        var cif = await _repo.GetByUtilizadorDisciplina(dto.UtilizadorId,dto.DisciplinaId);

        if (cif == null)
            return null;

        cif.ChangeCifDisciplina(new CifDisciplina(dto.CifDisciplina));


        await this._unitOfWork.CommitAsync();

        return new CifDTO(cif.Id.IntValue, cif.CifDisciplina.DisciplinaCif,
            cif.UtilizadorId.IntValue,
            cif.DisciplinaCodigo.StringValue);
    }
    
    
/*
    public async Task<DeliveryDTO> InactivateAsync(Identifier id)
    {
        var delivery = await _repo.GetByIdAsync(id);

        if (delivery == null)
            return null;

        delivery.MarkAsInative();

        await _unitOfWork.CommitAsync();

        return new DeliveryDTO(delivery.Id.AsGuid(), delivery.DeliveryId.DeliveryIdentifier, delivery.DeliveryDate.Day,
            delivery.DeliveryDate.Month,
            delivery.DeliveryDate.Year, delivery.DeliveryMass.Mass, delivery.DeliveryTime.placingTime,
            delivery.WarehouseId.ToString(),
            delivery.DeliveryTime.withdrawalTime);
    }*/

    public async Task<CifDTO> DeleteAsync(Identifier id)
    {
        var cif = await _repo.GetByIdAsync(id);

        if (cif == null)
            return null;

        //if (cif.Active)
           // throw new BusinessRuleValidationException("It is not possible to delete an active delivery plan.");

        _repo.Remove(cif);
        await _unitOfWork.CommitAsync();

        return new CifDTO(cif.Id.IntValue, cif.CifDisciplina.DisciplinaCif,
            cif.UtilizadorId.IntValue,
            cif.DisciplinaCodigo.StringValue);
    }
}