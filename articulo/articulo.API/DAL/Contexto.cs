using Compartido.Models;
using Microsoft.EntityFrameworkCore;

namespace articulo.API.DAL
{
    public class Contexto :DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Articulo> Articulos { get; set; }
    }
}
