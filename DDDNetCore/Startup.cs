﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Domain.Curso;
using WebApplication1.Domain.Disciplina;
using WebApplication1.Domain.Disciplina_CursoSecundario;
using WebApplication1.Domain.Escola;
using WebApplication1.Infrastructure;
using WebApplication1.Infrastructure.Curso;
using WebApplication1.Infrastructure.Disciplina;
using WebApplication1.Infrastructure.Disciplina_CursoSecundario;
using WebApplication1.Infrastructure.Escola;
using WebApplication1.Infrastructure.Shared;
using WebApplication1.Shared;

namespace WebApplication1;

public class Startup
{
    public readonly string LocalHostsAllowed = "_allowedLocalHosts";

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DDDSample1DbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString(
                    "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;Encrypt=true;TrustServerCertificate=true;"))
                .ReplaceService<IValueConverterSelector, StronglyEntityIdValueConverterSelector>());
        ConfigureMyServices(services);

        services.AddDbContext<DDDSample1DbContext>(opt =>
            opt.UseInMemoryDatabase("DDDSample1DB")
                .ReplaceService<IValueConverterSelector, StronglyEntityIdValueConverterSelector>());


        ConfigureMyServices(services);

        services.AddControllers().AddNewtonsoftJson();
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAll",
                builder => { builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); });
        });
    }


    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseCors(LocalHostsAllowed);

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }

    public void ConfigureMyServices(IServiceCollection services)
    {
        services.AddCors(opt =>
        {
            opt.AddPolicy(LocalHostsAllowed, b => { b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); });
        });

        services.AddTransient<IUnitOfWork, UnitOfWork>();

        services.AddTransient<ICursoRepository, CursoRepository>();
        services.AddTransient<ICursoService, CursoService>();
        services.AddTransient<IDisciplinaRepository, DisciplinaRepository>();
        services.AddTransient<IDisciplinaService, DisciplinaService>();
        services.AddTransient<IEscolaRepository, EscolaRepository>();
        services.AddTransient<IEscolaService, EscolaService>();
        services.AddTransient<IDisciplina_CursoSecundarioRepository, Disciplina_CursoSecundarioRepository>();
        services.AddTransient<IDisciplina_CursoSecundarioService, Disciplina_CursoSecundarioService>();
    }
}