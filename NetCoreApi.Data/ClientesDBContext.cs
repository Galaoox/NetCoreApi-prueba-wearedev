using Microsoft.EntityFrameworkCore;
using NetCoreApi.Data.Models;

#nullable disable

namespace NetCoreApi.Data
{
    public partial class ClientesDBContext : DbContext
    {

        public ClientesDBContext(DbContextOptions<ClientesDBContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
