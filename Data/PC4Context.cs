
using Microsoft.EntityFrameworkCore;

namespace PC4.Models
{
 
namespace PC4.Models
{
    public class PC4Context : DbContext
    {
        public DbSet<Usuario> DataUsuarios {get; set;}


        public PC4Context (DbContextOptions dco) : base(dco) 
        {

        }

    }

    }
}