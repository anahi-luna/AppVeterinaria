using AppVeterinaria.Models;
using Microsoft.EntityFrameworkCore;

namespace AppVeterinaria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options){}

        public DbSet<Cliente> Clientes { get; set; } //Acceso a la Tabla Cliente CRUD
    }
}
