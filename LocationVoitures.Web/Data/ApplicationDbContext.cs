using LocationVoitures.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace LocationVoitures.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Les entités (DbSet) seront ajoutées dans la Partie 2.
        public DbSet<CategoryVoiture> CategoriesVoitures { get; set; }
    }
}