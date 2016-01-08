using System.Data.Entity;
using INTRANET_MVC5.Infrastructure.Data.Entities;

namespace INTRANET_MVC5.Infrastructure.Data
{
    public interface IDbContext : CoreEntityFramework.IDbContext
    {
        DbSet<SampleData> SampleData { get; set; } 
    }
}