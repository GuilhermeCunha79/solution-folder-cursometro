using WebApplication1.Domain.Distrito;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Media;

public class MediaService : IMediaService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMediaRepository _repo;

    public MediaService(IUnitOfWork unitOfWork, IMediaRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<MediaDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<MediaDTO> listDto = list.ConvertAll(media =>
            new MediaDTO(media.Id.IntValue, media.MediaSecundario.SecundarioMedia, media.MediaIngresso.IngressoMedia,
                media.MediaIngressoDesporto.IngressoMediaDesporto, media.UtilizadorId.StringValue));

        return listDto;
    }

    public async Task<MediaDTO> GetByIdAsync(Identifier id)
    {
        var media = await _repo.GetByIdAsync(id);

        return new MediaDTO(media.Id.IntValue, media.MediaSecundario.SecundarioMedia, media.MediaIngresso.IngressoMedia,
            media.MediaIngressoDesporto.IngressoMediaDesporto, media.UtilizadorId.StringValue);
    }

    public async Task<MediaDTO> GetByUtilizadorId(Identifier idUtilizador)
    {
        var media = await _repo.GetByIdUtilizador(idUtilizador.StringValue);

        return new MediaDTO(media.Id.IntValue, media.MediaSecundario.SecundarioMedia, media.MediaIngresso.IngressoMedia,
            media.MediaIngressoDesporto.IngressoMediaDesporto, media.UtilizadorId.StringValue);
    }

    public async Task<MediaDTO> AddAsync(MediaDTO dto)
    {
        var media = new Media(dto.MediaSecundario, dto.MediaIngresso, dto.MediaIngressoDesporto, dto.UtilizadorId);

        await _repo.AddAsync(media);

        await _unitOfWork.CommitAsync();

        return new MediaDTO(media.Id.IntValue, media.MediaSecundario.SecundarioMedia, media.MediaIngresso.IngressoMedia,
            media.MediaIngressoDesporto.IngressoMediaDesporto, media.UtilizadorId.StringValue);
    }

    public async Task<MediaDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<MediaDTO> DeleteAsync(Identifier id)
    {
        var media = await _repo.GetByIdAsync(id);

        if (media == null)
            return null;

        _repo.Remove(media);
        await _unitOfWork.CommitAsync();

        return new MediaDTO(media.Id.IntValue, media.MediaSecundario.SecundarioMedia, media.MediaIngresso.IngressoMedia,
            media.MediaIngressoDesporto.IngressoMediaDesporto, media.UtilizadorId.StringValue);
    }

    public async Task<MediaDTO> UpdateAsync(MediaDTO dto)
    {
        var media = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new MediaDTO(media.Id.IntValue, media.MediaSecundario.SecundarioMedia, media.MediaIngresso.IngressoMedia,
            media.MediaIngressoDesporto.IngressoMediaDesporto, media.UtilizadorId.StringValue);
    }
}