
using Microsoft.EntityFrameworkCore;

namespace PC4.Models
{
 
namespace PC4.Models
{
    public class Practica4Context : DbContext
    {
        public DbSet<Usuario> DataUsuarios {get; set;}


        public Practica4Context (DbContextOptions dco) : base(dco) 
        {

        }

    }

    }
}