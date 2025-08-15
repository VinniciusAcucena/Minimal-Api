using System.Data.Common;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;
    public AdministradorServico(DbBatch DbContexto)
    {

    }
    public List<Administrador> Login(LoginDTO loginDTO)
    {
        throw new NotImplementedException();
    }
}