using EdgeCut.Entities;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace EdgeCut.DAL
{
    public class EdgeDbContext: DbContext
    {

        public EdgeDbContext(DbContextOptions<EdgeDbContext> options): base(options) {}

        public DbSet<Product> Products { get; set; }
    }
}
