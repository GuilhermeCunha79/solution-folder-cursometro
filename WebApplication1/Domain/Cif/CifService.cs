using ConsoleApp1.Domain.Cif;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Cif;

public class CifService:ICifService
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

        List<CifDTO> listDto = list.ConvertAll(cif => new CifDTO(cif.Id.IntValue,cif.CifPortugues.PortuguesCif,
            cif.CifEduFisica.EduFisicaCif, cif.CifFilosofia.FilosofiaCif,cif.CifLinguaEstrangeira.LinguaEstrangeiraCif,
            cif.CifTrienal.TrienalCif,cif.CifBienal1.Bienal1Cif,cif.CifBienal2.Bienal2Cif,cif.CifAnual1.Anual1Cif,
            cif.CifAnual2.Anual2Cif,cif.UtilizadorId.IntValue));
        
        return listDto;
    }

    public async Task<CifDTO> GetByIdAsync(Identifier id)
    {
        var cif = await _repo.GetByIdAsync(id);
        
        return new CifDTO(cif.Id.IntValue,cif.CifPortugues.PortuguesCif,
            cif.CifEduFisica.EduFisicaCif, cif.CifFilosofia.FilosofiaCif,cif.CifLinguaEstrangeira.LinguaEstrangeiraCif,
            cif.CifTrienal.TrienalCif,cif.CifBienal1.Bienal1Cif,cif.CifBienal2.Bienal2Cif,cif.CifAnual1.Anual1Cif,
            cif.CifAnual2.Anual2Cif,cif.UtilizadorId.IntValue);
    }

    public async Task<CifDTO> GetByUtilizadorId(Identifier utilizadorId)
    {
        var cif = await _repo.GetByUtilizadorId(utilizadorId.IntValue);
        
        return new CifDTO(cif.Id.IntValue,cif.CifPortugues.PortuguesCif,
            cif.CifEduFisica.EduFisicaCif, cif.CifFilosofia.FilosofiaCif,cif.CifLinguaEstrangeira.LinguaEstrangeiraCif,
            cif.CifTrienal.TrienalCif,cif.CifBienal1.Bienal1Cif,cif.CifBienal2.Bienal2Cif,cif.CifAnual1.Anual1Cif,
            cif.CifAnual2.Anual2Cif,cif.UtilizadorId.IntValue);
    }

    public async Task<CifDTO> AddAsync(CifDTO dto)
    {
        var cif = new Cif(dto.CifPortugues,dto.CifEduFisica,dto.CifFilosofia,dto.CifLinguaEstrangeira,dto.CifTrienal,
            dto.CifBienal1,dto.CifBienal2,dto.CifAnual1,dto.CifAnual2,dto.UtilizadorId);
        
        await _repo.AddAsync(cif);
        
        return new CifDTO(cif.Id.IntValue,cif.CifPortugues.PortuguesCif,
            cif.CifEduFisica.EduFisicaCif, cif.CifFilosofia.FilosofiaCif,cif.CifLinguaEstrangeira.LinguaEstrangeiraCif,
            cif.CifTrienal.TrienalCif,cif.CifBienal1.Bienal1Cif,cif.CifBienal2.Bienal2Cif,cif.CifAnual1.Anual1Cif,
            cif.CifAnual2.Anual2Cif,cif.UtilizadorId.IntValue); 
    }
}