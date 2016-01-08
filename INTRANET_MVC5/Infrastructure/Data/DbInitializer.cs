using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INTRANET_MVC5.Infrastructure.Data
{
    public class DbInitializer : System.Data.Entity.CreateDatabaseIfNotExists<DbContext>
    {
        protected override void Seed(DbContext context)
        {
            base.Seed(context);
            //new DbInitializerHelper(context).Init();
        }
    }
}