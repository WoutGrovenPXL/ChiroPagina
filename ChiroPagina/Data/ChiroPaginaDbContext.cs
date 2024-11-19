using ChiroPagina.Models;
using Microsoft.EntityFrameworkCore;

namespace ChiroPagina.Data
{
	public class ChiroPaginaDbContext : DbContext
	{

        public ChiroPaginaDbContext(DbContextOptions<ChiroPaginaDbContext> options) : base(options)
        {
            
        }

        public DbSet<Event> Events { get; set; } 
    }
}
