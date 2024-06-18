using WebApplication1.Domain.Distrito;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso_ExameIngresso;

public class Instituicao_Curso_ExameIngressoService : IInstituicao_Curso_ExameIngressoService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IInstituicao_Curso_ExameIngressoRepository _repo;

    public Instituicao_Curso_ExameIngressoService(IUnitOfWork unitOfWork,
        IInstituicao_Curso_ExameIngressoRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<Instituicao_Curso_ExameIngressoDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<Instituicao_Curso_ExameIngressoDTO> listDto = list.ConvertAll(instituicao =>
            new Instituicao_Curso_ExameIngressoDTO(instituicao.Id.IntValue,
                instituicao.InstituicaoCursoCodigo.StringValue, instituicao.ExameIngressoCodigo.StringValue));

        return listDto;
    }

    public async Task<Instituicao_Curso_ExameIngressoDTO> GetByIdAsync(Identifier id)
    {
        var instituicao = await _repo.GetByIdAsync(id);

        return new Instituicao_Curso_ExameIngressoDTO(instituicao.Id.IntValue,
            instituicao.InstituicaoCursoCodigo.StringValue, instituicao.ExameIngressoCodigo.StringValue);
    }

    public async Task<Instituicao_Curso_ExameIngressoDTO> AddAsync(Instituicao_Curso_ExameIngressoDTO dto)
    {
        var instituicao = new Instituicao_Curso_ExameIngresso(dto.InstituicaoCursoCodigo, dto.CodigoExame);

        await _repo.AddAsync(instituicao);

        await _unitOfWork.CommitAsync();

        return new Instituicao_Curso_ExameIngressoDTO(instituicao.Id.IntValue,
            instituicao.InstituicaoCursoCodigo.StringValue, instituicao.ExameIngressoCodigo.StringValue);
    }

    public async Task<Instituicao_Curso_ExameIngressoDTO> InactivateAsync(Identifier id)
    {
        throw new NotImplementedException();
    }

    public async Task<Instituicao_Curso_ExameIngressoDTO> DeleteAsync(Identifier id)
    {
        var instituicao = await _repo.GetByIdAsync(id);

        if (instituicao == null)
            return null;

        _repo.Remove(instituicao);
        await _unitOfWork.CommitAsync();

        return new Instituicao_Curso_ExameIngressoDTO(instituicao.Id.IntValue,
            instituicao.InstituicaoCursoCodigo.StringValue, instituicao.ExameIngressoCodigo.StringValue);
    }

    public async Task<Instituicao_Curso_ExameIngressoDTO> UpdateAsync(Instituicao_Curso_ExameIngressoDTO dto)
    {
        var instituicao = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new Instituicao_Curso_ExameIngressoDTO(instituicao.Id.IntValue,
            instituicao.InstituicaoCursoCodigo.StringValue, instituicao.ExameIngressoCodigo.StringValue);
    }
}