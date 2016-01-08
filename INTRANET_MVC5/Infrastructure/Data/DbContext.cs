using System.Data.Entity;
using INTRANET_MVC5.Infrastructure.Data.Entities;

namespace INTRANET_MVC5.Infrastructure.Data
{
    public class DbContext : CoreEntityFramework.DbContext, IDbContext
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public DbContext()
            : base("SampleDataContext")
        {
        }

        public DbSet<SampleData> SampleData { get; set; }

    }
}