using Microsoft.EntityFrameworkCore;
using WellN_M2_AgenciaViagens.Models;

namespace WellN_M2_AgenciaViagens.Data;

public class AppDatabaseContext: DbContext
{
    public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options): base(options)
    {
    }

    public DbSet<Pacotes> dbPackages { get; set; }
    public DbSet<Clientes> dbClients { get; set; }
    public DbSet<Compras> dbBuyList { get; set; }
    public DbSet<WellN_M2_AgenciaViagens.Models.Suporte> Suporte { get; set; }
}

