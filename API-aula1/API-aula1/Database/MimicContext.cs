using API_aula1.Models;
using Microsoft.EntityFrameworkCore;

namespace API_aula1.Database
{
    public class MimicContext : DbContext
    {
        public MimicContext(DbContextOptions<MimicContext> options) : base(options)
        {   
        
        }
        public DbSet<Palavra> Palavras { get; set; }
    }
}
