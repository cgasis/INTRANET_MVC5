namespace INTRANET_MVC5.Infrastructure.Data
{
    public class DbInitializerHelper
    {
        private readonly DbContext _dbContext;

        public DbInitializerHelper(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Init()
        {
            _dbContext.SaveChanges();
        }
    }
}