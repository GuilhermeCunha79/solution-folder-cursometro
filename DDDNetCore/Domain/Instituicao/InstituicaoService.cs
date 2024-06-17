using WebApplication1.Domain.Distrito;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoService : IInstituicaoService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IInstituicaoRepository _repo;

    public InstituicaoService(IUnitOfWork unitOfWork, IInstituicaoRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<InstituicaoDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<InstituicaoDTO> listDto = list.ConvertAll(instituicao =>
            new InstituicaoDTO(instituicao.Id.StringValue, instituicao.Nome.Nome, instituicao.Morada.Morada,
                instituicao.Telefone.Telefone, instituicao.TipoEnsino.TipoEnsino, instituicao.Fax.Fax,
                instituicao.Email.Email,
                instituicao.Logo.Logo, instituicao.IdRanking.IntValue, instituicao.MapaLink.MapaLink,
                instituicao.PaginaLink.LinkInstituicao));

        return listDto;
    }

    public async Task<InstituicaoDTO> GetByIdAsync(Identifier id)
    {
        var instituicao = await _repo.GetByIdAsync(id);

        return new InstituicaoDTO(instituicao.Id.StringValue, instituicao.Nome.Nome, instituicao.Morada.Morada,
            instituicao.Telefone.Telefone, instituicao.TipoEnsino.TipoEnsino, instituicao.Fax.Fax,
            instituicao.Email.Email,
            instituicao.Logo.Logo, instituicao.IdRanking.IntValue, instituicao.MapaLink.MapaLink,
            instituicao.PaginaLink.LinkInstituicao);
    }

    public async Task<InstituicaoDTO> GetByCodigo(Identifier id)
    {
        var instituicao = await _repo.GetByCodigo(id.StringValue);

        return new InstituicaoDTO(instituicao.Id.StringValue, instituicao.Nome.Nome, instituicao.Morada.Morada,
            instituicao.Telefone.Telefone, instituicao.TipoEnsino.TipoEnsino, instituicao.Fax.Fax,
            instituicao.Email.Email,
            instituicao.Logo.Logo, instituicao.IdRanking.IntValue, instituicao.MapaLink.MapaLink,
            instituicao.PaginaLink.LinkInstituicao);
    }

    public async Task<InstituicaoDTO> AddAsync(InstituicaoDTO dto)
    {
        var instituicao = new Instituicao(dto.Nome, dto.Email, dto.Codigo, dto.Fax, dto.Logo, dto.Morada, dto.Telefone,
            dto.TipoEnsino, dto.MapaLink, dto.PaginaLink, dto.IdRanking);

        await _repo.AddAsync(instituicao);

        await _unitOfWork.CommitAsync();

        return new InstituicaoDTO(instituicao.Id.StringValue, instituicao.Nome.Nome, instituicao.Morada.Morada,
            instituicao.Telefone.Telefone, instituicao.TipoEnsino.TipoEnsino, instituicao.Fax.Fax,
            instituicao.Email.Email,
            instituicao.Logo.Logo, instituicao.IdRanking.IntValue, instituicao.MapaLink.MapaLink,
            instituicao.PaginaLink.LinkInstituicao);
    }

    public async Task<InstituicaoDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<InstituicaoDTO> DeleteAsync(Identifier id)
    {
        var instituicao = await _repo.GetByIdAsync(id);

        if (instituicao == null)
            return null;

        _repo.Remove(instituicao);
        await _unitOfWork.CommitAsync();

        return new InstituicaoDTO(instituicao.Id.StringValue, instituicao.Nome.Nome, instituicao.Morada.Morada,
            instituicao.Telefone.Telefone, instituicao.TipoEnsino.TipoEnsino, instituicao.Fax.Fax,
            instituicao.Email.Email,
            instituicao.Logo.Logo, instituicao.IdRanking.IntValue, instituicao.MapaLink.MapaLink,
            instituicao.PaginaLink.LinkInstituicao);
    }

    public async Task<InstituicaoDTO> UpdateAsync(InstituicaoDTO dto)
    {
        var instituicao = await _repo.GetByIdAsync(new Identifier(dto.Codigo));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new InstituicaoDTO(instituicao.Id.StringValue, instituicao.Nome.Nome, instituicao.Morada.Morada,
            instituicao.Telefone.Telefone, instituicao.TipoEnsino.TipoEnsino, instituicao.Fax.Fax,
            instituicao.Email.Email,
            instituicao.Logo.Logo, instituicao.IdRanking.IntValue, instituicao.MapaLink.MapaLink,
            instituicao.PaginaLink.LinkInstituicao);
    }
}