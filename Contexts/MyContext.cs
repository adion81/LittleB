using Microsoft.EntityFrameworkCore;
using LizardPirates.Models;

namespace LizardPirates.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}

        public DbSet<Lizard> Lizards {get;set;}
    }
}