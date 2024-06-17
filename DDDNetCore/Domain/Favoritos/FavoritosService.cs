using WebApplication1.Shared;

namespace WebApplication1.Domain.Favoritos;

public class FavoritosService : IFavoritosService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFavoritosRepository _repo;

    public FavoritosService(IUnitOfWork unitOfWork, IFavoritosRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<FavoritosDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<FavoritosDTO> listDto = list.ConvertAll(favoritos =>
            new FavoritosDTO(favoritos.Id.IntValue,favoritos.UtilizadorId.StringValue,
                favoritos.InstituicaoCursoCodigo.StringValue));

        return listDto;
    }

    public async Task<FavoritosDTO> GetByIdAsync(Identifier id)
    {
        var favoritos = await _repo.GetByIdAsync(id);

        return new FavoritosDTO(favoritos.Id.IntValue,favoritos.UtilizadorId.StringValue,
            favoritos.InstituicaoCursoCodigo.StringValue);
    }
    
    public async Task<List<FavoritosDTO>> GetByUtilizadorId(Identifier utilizadorId)
    {
        var escolaList = await _repo.GetByUtilizadorId(utilizadorId);

        List<FavoritosDTO> list = escolaList.ConvertAll(favoritos =>
            new FavoritosDTO(favoritos.Id.IntValue,favoritos.UtilizadorId.StringValue,
                favoritos.InstituicaoCursoCodigo.StringValue));

        return list;
    }

    public async Task<FavoritosDTO> AddAsync(FavoritosDTO dto)
    {
        var favoritos = new Favoritos(dto.IdUtilizador, dto.InstituicaoCursoCodigo);

        await _repo.AddAsync(favoritos);

        await _unitOfWork.CommitAsync();

        return new FavoritosDTO(favoritos.Id.IntValue,favoritos.UtilizadorId.StringValue,
            favoritos.InstituicaoCursoCodigo.StringValue);
    }


    public async Task<FavoritosDTO> DeleteAsync(Identifier id)
    {
        var favoritos = await _repo.GetByIdAsync(id);

        if (favoritos == null)
            return null;

        _repo.Remove(favoritos);
        await _unitOfWork.CommitAsync();

        return new FavoritosDTO(favoritos.Id.IntValue,favoritos.UtilizadorId.StringValue,
            favoritos.InstituicaoCursoCodigo.StringValue);
    }
    

    public async Task<FavoritosDTO> UpdateAsync(FavoritosDTO dto)
    {
        var favoritos = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new FavoritosDTO(favoritos.Id.IntValue,favoritos.UtilizadorId.StringValue,
            favoritos.InstituicaoCursoCodigo.StringValue);
    }
}