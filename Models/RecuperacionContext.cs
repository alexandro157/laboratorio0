using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace recuperacion.Models
{
    public class RecuperacionContext : DbContext
    {
        public RecuperacionContext(DbContextOptions<RecuperacionContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
