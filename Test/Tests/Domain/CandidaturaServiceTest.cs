/*using Moq;
using WebApplication1.Domain.Candidatura;
using WebApplication1.Shared;

namespace tests.Tests.Domain;


public class CandidaturaServiceTest
{
    [Fact]
    public async void GetAllAsyncTest()
    {
        var repo = new Mock<ICandidaturaRepository>();
        var unit = new Mock<IUnitOfWork>();

        int idCandidatura = 1;
        int ano = 2024;
        int fase = 1;
        string cod = "LIC/PORT";

        var candidatura = new Candidatura(cod, ano, fase);
        typeof(Candidatura).GetProperty("Id").SetValue(candidatura, new Identifier(idCandidatura));

        var candidaturaDto = new CandidaturaDTO(idCandidatura, cod, ano, fase);

        var candidaturaDtoList = new List<CandidaturaDTO> { candidaturaDto };
        var candidaturaList = new List<Candidatura> { candidatura };

        repo.Setup(_ => _.GetAllAsync()).ReturnsAsync(candidaturaList);

        var deliveryService = new CandidaturaService(unit.Object, repo.Object);

        var actual = await deliveryService.GetAllAsync();

        Assert.Equal(candidaturaDtoList.Count, actual.Count);
    }

    [Fact]
    public async void AddCandidaturaTest()
    {
        var repo = new Mock<ICandidaturaRepository>();
        var unit = new Mock<IUnitOfWork>();

        int idCandidatura = 1;
        int ano = 2024;
        int fase = 1;
        string cod = "LIC/PORT";

        var candidatura = new Candidatura(cod, ano, fase);
        var candidaturaDto = new CandidaturaDTO(idCandidatura, cod, ano, fase);

        repo.Setup(_ => _.AddAsync(It.IsAny<Candidatura>())).Callback<Candidatura>(c =>
        {
            c.GetType().GetProperty("Id").SetValue(c, new Identifier(idCandidatura));
        }).ReturnsAsync(candidatura);

        var candidaturaService = new CandidaturaService(unit.Object, repo.Object);

        var actual = await candidaturaService.AddAsync(candidaturaDto);

        Assert.Equal(candidaturaDto.Id, actual.Id);
    }
    
    [Fact]
     public async void GetByIdAsyncTest()
     {
         var repo = new Mock<ICandidaturaRepository>();
         var unit = new Mock<IUnitOfWork>();

         int idCandidatura = 1;
         int ano = 2024;
         int fase = 1;
         string cod = "LIC/PORT";

         var candidatura = new Candidatura(cod, ano, fase);
         typeof(Candidatura).GetProperty("Id").SetValue(candidatura, new Identifier(idCandidatura));
         repo.Setup(_ => _.AddAsync(It.IsAny<Candidatura>())).Callback<Candidatura>(c =>
         {
             c.GetType().GetProperty("Id").SetValue(c, new Identifier(idCandidatura));
         }).ReturnsAsync(candidatura);
         
         var candidaturaDto = new CandidaturaDTO(idCandidatura, cod, ano, fase);

         var candidaturaService = new CandidaturaService(unit.Object, repo.Object);
         var actual1=await candidaturaService.AddAsync(candidaturaDto);

         var actual = await candidaturaService.GetByIdAsync(candidatura.Id);
    
         Assert.Equal(candidaturaDto, actual);
     }
    
    [Fact]
    public async void UpdateAsyncTest()
    {
        var repo = new Mock<ICandidaturaRepository>();
        var unit = new Mock<IUnitOfWork>();

        int idCandidatura = 1;
        int ano = 2024;
        int fase = 1;
        string cod = "LIC/PORT";

        var candidatura = new Candidatura(cod, ano, fase);
        var candidaturaDto = new CandidaturaDTO(idCandidatura, cod, ano, fase);
        typeof(Candidatura).GetProperty("Id").SetValue(candidatura, new Identifier(idCandidatura));
        repo.Setup(_ => _.AddAsync(It.IsAny<Candidatura>())).Callback<Candidatura>(c =>
        {
            c.GetType().GetProperty("Id").SetValue(c, new Identifier(idCandidatura));
        }).ReturnsAsync(candidatura);
    
        var candidaturaService = new CandidaturaService(unit.Object, repo.Object);
    
        candidatura.ChangeCandidaturaAno(new CandidaturaAno(2027));
         
        var actual = await candidaturaService.UpdateAsync(candidaturaDto);
        Assert.Equal(candidatura.CandidaturaAno.Ano, actual.Ano);
    }
}*/