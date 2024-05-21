using Microsoft.EntityFrameworkCore;
using PrivateBlog.Web.Data.Entities;
using System.Data.Common;

namespace PrivateBlog.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            // No es necesario agregar lógica adicional en el constructor en este caso.
        }
        
        public DbSet<Section> Sections { get; set; }
    }
}
