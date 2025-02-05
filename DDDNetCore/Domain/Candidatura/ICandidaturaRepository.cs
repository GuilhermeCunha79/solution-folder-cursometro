﻿using WebApplication1.Shared;
using System.Threading.Tasks;
namespace WebApplication1.Domain.Candidatura;

public interface ICandidaturaRepository:IRepository<Candidatura,Identifier>
{
    Task<Candidatura> GetByCodigoCurso(string codigo);
}