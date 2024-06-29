using WebApplication1.Domain.Distrito;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_CursoService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IInstituicao_CursoRepository _repo;

    public Instituicao_CursoService(IUnitOfWork unitOfWork, IInstituicao_CursoRepository repo)
    {
        _unitOfWork = unitOfWork;
        _repo = repo;
    }

    public async Task<List<Instituicao_CursoDTO>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();

        List<Instituicao_CursoDTO> listDto = list.ConvertAll(instituicaoCurso =>
            new Instituicao_CursoDTO(instituicaoCurso.Id.StringValue,
                instituicaoCurso.InstituicaoCodigo.StringValue, instituicaoCurso.InstituicaoCursoEcts.ECTS,
                instituicaoCurso.InstituicaoArea.AreaInstituicao, instituicaoCurso.InstituicaoCursoDuracao.Duracao,
                instituicaoCurso.InstituicaoCursoGrau.Grau));

        return listDto;
    }

    public async Task<Instituicao_CursoDTO> GetByIdAsync(Identifier id)
    {
        var instituicaoCurso = await _repo.GetByIdAsync(id);

        return new Instituicao_CursoDTO(instituicaoCurso.Id.StringValue,
            instituicaoCurso.InstituicaoCodigo.StringValue, instituicaoCurso.InstituicaoCursoEcts.ECTS,
            instituicaoCurso.InstituicaoArea.AreaInstituicao, instituicaoCurso.InstituicaoCursoDuracao.Duracao,
            instituicaoCurso.InstituicaoCursoGrau.Grau);
    }

    public async Task<Instituicao_CursoDTO> AddAsync(Instituicao_CursoDTO dto)
    {
        var instituicaoCurso = new Instituicao_Curso(dto.CodigoInstituicao, dto.CodigoCurso, dto.Ects, dto.Duracao,
            dto.Grau, dto.Area);

        await _repo.AddAsync(instituicaoCurso);

        await _unitOfWork.CommitAsync();

        return new Instituicao_CursoDTO(instituicaoCurso.Id.StringValue,
            instituicaoCurso.InstituicaoCodigo.StringValue, instituicaoCurso.InstituicaoCursoEcts.ECTS,
            instituicaoCurso.InstituicaoArea.AreaInstituicao, instituicaoCurso.InstituicaoCursoDuracao.Duracao,
            instituicaoCurso.InstituicaoCursoGrau.Grau);
    }

    public async Task<Instituicao_CursoDTO> InactivateAsync(Identifier id)
    {
        var instituicaoCurso = await _repo.GetByIdAsync(id);

        if (instituicaoCurso == null)
            return null;

        instituicaoCurso.MarkAsInactive();

        await _unitOfWork.CommitAsync();

        return new Instituicao_CursoDTO(instituicaoCurso.Id.StringValue,
            instituicaoCurso.InstituicaoCodigo.StringValue, instituicaoCurso.InstituicaoCursoEcts.ECTS,
            instituicaoCurso.InstituicaoArea.AreaInstituicao, instituicaoCurso.InstituicaoCursoDuracao.Duracao,
            instituicaoCurso.InstituicaoCursoGrau.Grau);
    }

    public async Task<Instituicao_CursoDTO> DeleteAsync(Identifier id)
    {
        var instituicaoCurso = await _repo.GetByIdAsync(id);

        if (instituicaoCurso == null)
            return null;

        _repo.Remove(instituicaoCurso);
        await _unitOfWork.CommitAsync();

        return new Instituicao_CursoDTO(instituicaoCurso.Id.StringValue,
            instituicaoCurso.InstituicaoCodigo.StringValue, instituicaoCurso.InstituicaoCursoEcts.ECTS,
            instituicaoCurso.InstituicaoArea.AreaInstituicao, instituicaoCurso.InstituicaoCursoDuracao.Duracao,
            instituicaoCurso.InstituicaoCursoGrau.Grau);
    }

    public async Task<Instituicao_CursoDTO> UpdateAsync(Instituicao_CursoDTO dto)
    {
        var instituicaoCurso = await _repo.GetByIdAsync(new Identifier(dto.Id));

        // change all fields


        await _unitOfWork.CommitAsync();

        return new Instituicao_CursoDTO(instituicaoCurso.Id.StringValue,
            instituicaoCurso.InstituicaoCodigo.StringValue, instituicaoCurso.InstituicaoCursoEcts.ECTS,
            instituicaoCurso.InstituicaoArea.AreaInstituicao, instituicaoCurso.InstituicaoCursoDuracao.Duracao,
            instituicaoCurso.InstituicaoCursoGrau.Grau);
    }
}